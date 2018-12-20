using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using Film3.Models;

namespace Film3.Service
{
    class EmotionService<T> : IDataService<T> where T : Emotion, new()
    {
        // перевести в mssql                    // заменить базу данных на корректную
        static readonly string sqlConnect =  @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alexs\Desktop\Main project\TestProj\TestProj\Users.mdf;Integrated Security=True";
        // ???? private string ConnectionString { get; set; }
        //SqlConnection conn = new SqlConnection(SqlConnection);
        //conn.Open();
        //    SqlCommand command = new SqlCommand("Select * from Clients", conn);

        public void Save(T file)
        {
            using (var conn = new SqlConnection(sqlConnect))
            {
                conn.Open();

                using (var command = new SqlCommand("Select * from Clients", conn))
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO emotion(contempt,disgust,anger,fear,happiness,neutral,sadness,surprise,photo_id,create_date) VALUES (@contempt,@disgust,@anger,@fear,@happiness,@neutral,@sadness,@surprise,@photo_id,@create_date)";
                    command.Parameters.AddWithValue("@contempt", file.Contempt);
                    command.Parameters.AddWithValue("@disgust", file.Disgust);
                    command.Parameters.AddWithValue("@anger", file.Anger);
                    command.Parameters.AddWithValue("@fear", file.Fear);
                    command.Parameters.AddWithValue("@happiness", file.Happiness);
                    command.Parameters.AddWithValue("@neutral", file.Neutral);
                    command.Parameters.AddWithValue("@sadness", file.Sadness);
                    command.Parameters.AddWithValue("@surprise", file.Surprise);
                    command.Parameters.AddWithValue("@photo_id", file.PhotoId);
                    command.Parameters.AddWithValue("@create_date", file.DateTimeCreate);

                    command.ExecuteNonQuery();
                }
            }
        }

        //public static List<Client> GetClients()
        //{
        //    List<Client> listCl = new List<Client>();
        //    SqlConnection conn = new SqlConnection(SqlConnection);
        //    conn.Open();
        //    SqlCommand command = new SqlCommand("Select * from Clients", conn);
        //    SqlDataReader reader = command.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Client client = new Client();
        //            client.Id = reader.GetInt32(0);
        //            client.Password = reader.GetValue(1).ToString();
        //            listCl.Add(client);
        //        }
        //    }
        //    reader.Close();
        //    conn.Close();
        //    return listCl;
        //}

        public IEnumerable<T> GetAll()
        {
            var result = new List<T>();
            using (var conn = new SqlConnection(sqlConnect))
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT contempt,disgust,anger,fear,happiness,neutral,sadness,surprise,photo_id,create_date FROM emotion";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        T entity = new T
                        {
                            PhotoId = int.Parse(reader[0].ToString()),
                            Contempt = int.Parse(reader[0].ToString()),
                            Disgust = int.Parse(reader[0].ToString()),
                            Anger = int.Parse(reader[0].ToString()),
                            Fear = int.Parse(reader[0].ToString()),
                            Happiness = int.Parse(reader[0].ToString()),
                            Neutral = int.Parse(reader[0].ToString()),
                            Sadness = int.Parse(reader[0].ToString()),
                            Surprise = int.Parse(reader[0].ToString()),
                            DateTimeCreate = Convert.ToDateTime(reader[3].ToString())
                        };
                        result.Add(entity);
                    }
                }

                return result;
            }
        }
    }
}
