namespace debut2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuest = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnNoReady = new System.Windows.Forms.Button();
            this.lblHiWindow = new System.Windows.Forms.Label();
            this.pcttBxLoser = new System.Windows.Forms.PictureBox();
            this.pcttBxWinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcttBxLoser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcttBxWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Location = new System.Drawing.Point(100, 70);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(35, 13);
            this.lblQuest.TabIndex = 0;
            this.lblQuest.Text = "label1";
            this.lblQuest.Visible = false;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(225, 399);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(35, 13);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "label1";
            this.lblCounter.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(55, 380);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 50);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Предыдущий вопрос";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(328, 380);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 50);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Следующий вопрос";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.DimGray;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReady.Location = new System.Drawing.Point(81, 172);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(100, 50);
            this.btnReady.TabIndex = 4;
            this.btnReady.Text = "Готов";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnNoReady
            // 
            this.btnNoReady.BackColor = System.Drawing.Color.DimGray;
            this.btnNoReady.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoReady.Location = new System.Drawing.Point(293, 172);
            this.btnNoReady.Name = "btnNoReady";
            this.btnNoReady.Size = new System.Drawing.Size(100, 50);
            this.btnNoReady.TabIndex = 5;
            this.btnNoReady.Text = "Не готов";
            this.btnNoReady.UseVisualStyleBackColor = false;
            // 
            // lblHiWindow
            // 
            this.lblHiWindow.AutoSize = true;
            this.lblHiWindow.Location = new System.Drawing.Point(172, 106);
            this.lblHiWindow.Name = "lblHiWindow";
            this.lblHiWindow.Size = new System.Drawing.Size(140, 13);
            this.lblHiWindow.TabIndex = 6;
            this.lblHiWindow.Text = "Хотители вы пройти тест?";
            // 
            // pcttBxLoser
            // 
            this.pcttBxLoser.Location = new System.Drawing.Point(0, 0);
            this.pcttBxLoser.Name = "pcttBxLoser";
            this.pcttBxLoser.Size = new System.Drawing.Size(100, 50);
            this.pcttBxLoser.TabIndex = 0;
            this.pcttBxLoser.TabStop = false;
            // 
            // pcttBxWinner
            // 
            this.pcttBxWinner.Location = new System.Drawing.Point(0, 0);
            this.pcttBxWinner.Name = "pcttBxWinner";
            this.pcttBxWinner.Size = new System.Drawing.Size(100, 50);
            this.pcttBxWinner.TabIndex = 0;
            this.pcttBxWinner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 461);
            this.Controls.Add(this.btnNoReady);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblHiWindow);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblQuest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pcttBxLoser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcttBxWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnNoReady;
        private System.Windows.Forms.Label lblHiWindow;
        private System.Windows.Forms.PictureBox pcttBxLoser;
        private System.Windows.Forms.PictureBox pcttBxWinner;
    }
}

