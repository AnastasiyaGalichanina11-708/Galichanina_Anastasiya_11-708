using debut2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debut2
{
    public static class Connection
    {
        static string SqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\Database1.mdf;Integrated Security=True";

        public static List<Question> GetQuestions()
        {
            List<Question> list = new List<Question>();

            SqlConnection conn = new SqlConnection(SqlConnection);

            conn.Open();

            SqlCommand command = new SqlCommand("Select * from Question", conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    Question question = new Question();
                    question.Id = reader.GetInt32(0);
                    question.Theme = reader.GetValue(1).ToString();
                    question.Quest = reader.GetValue(2).ToString();
                    question.OkQuest = reader.GetInt32(3);
                    question.Answers = GetAnswers(question.Id);
                    list.Add(question);
                }
            }

            reader.Close();

            conn.Close();
            return list;
        }

        public static List<Answer> GetAnswers(int id)
        {
            List<Answer> list = new List<Answer>();

            SqlConnection conn = new SqlConnection(SqlConnection);

            conn.Open();

            SqlCommand command = new SqlCommand("Select * from Answer Where QuestId = " + id, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    Answer answer = new Answer();

                    answer.QuestId = reader.GetInt32(1);
                    answer.Description = reader.GetValue(2).ToString();
                    answer.Id = reader.GetInt32(3);
                    list.Add(answer);
                }
            }

            reader.Close();

            conn.Close();
            return list;
        }
    }
}
