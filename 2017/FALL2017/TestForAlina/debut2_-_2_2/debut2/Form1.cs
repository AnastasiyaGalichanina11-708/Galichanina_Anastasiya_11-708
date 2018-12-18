using debut2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debut2
{
    public partial class Form1 : Form
    {
        Question question;
        int step = 1;
        int trueAnswer;
        int a = 0, i = 0;
        int[] trueAnsw = new int[10];
        int trueSum = 0;

        public Form1()
        {
            InitializeComponent();
            question = new Question();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Удаляем объекты ответы предыдущие
            FuncDelete();

            //Изменяем вопрос  и добавляем ответы
            FuncShow();

            //Действие на определённый шаг
            FuncCheck();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            lblCounter.Visible = true;
            lblQuest.Visible = true;
            btnNext.Visible = true;
            lblHiWindow.Visible = false;
            btnReady.Visible = false;
            btnNoReady.Visible = false;
            btnNext_Click(btnNext, null);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При возврате ответ сбрасывается", "Внимание");
            trueAnsw[step - 2] = 0;
            step -= 2;
            btnNext_Click(btnNext, null);
        }

        private void checkRbt(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

        private void FuncCheck()
        {
            if (step > 1)
                btnReturn.Visible = true;
            else
                btnReturn.Visible = false;

            switch (step)
            {
                case 11:
                    {
                        btnNext.Visible = false;
                        btnReturn.Visible = false;
                        lblQuest.Visible = false;
                        lblCounter.Visible = false;
                        foreach (int answ in trueAnsw)
                            trueSum += answ;
                        if (trueSum != 0)
                        {
                            MessageBox.Show("Вы ответили правильно на " + trueSum + " из 10", "Поздравляем вы прошли тест");
                        }
                        else
                        {
                            MessageBox.Show("Ты проиграл");
                        }
                        Application.Exit();
                        break;
                    }
                case 10:
                    {
                        btnNext.Text = "Завершить тест";
                        btnNext.Enabled = false;
                        step++;
                        break;
                    }
                default:
                    {
                        step++;
                        btnNext.Enabled = false;
                        break;
                    }
            }
        }

        private void FuncDelete()
        {
            a = 0;
            while (a <= i)
            {
                if (this.Controls.IndexOfKey("rbt_" + a) > -1)
                {
                    var rbt1 = (RadioButton)this.Controls[this.Controls.IndexOfKey("rbt_" + a)];
                    if (rbt1.Checked && (int)rbt1.Tag == trueAnswer)
                    {
                        trueAnsw[step - 2] = 1;
                    }
                }
                this.Controls.RemoveByKey("rbt_" + a);
                a++;
            }
        }

        private void FuncShow()
        {
            var list = Connection.GetQuestions();
            foreach (Question quest in list)
            {
                if (quest.Id == step)
                {
                    lblQuest.Text = quest.Quest;
                    trueAnswer = quest.OkQuest;
                    lblCounter.Text = step + " из 10";
                    i = 0;
                    foreach (Answer asnw in quest.Answers)
                    {
                        RadioButton rbt = new RadioButton();
                        rbt.Name = "rbt_" + i;
                        rbt.Text = asnw.Description;
                        rbt.Tag = i;
                        rbt.Location = new Point(100, 100 + 30 * i);
                        rbt.AutoSize = true;
                        rbt.CheckedChanged += new System.EventHandler(this.checkRbt);
                        this.Controls.Add(rbt);
                        i++;
                    }
                }
            }
        }
    }
}