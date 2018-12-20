using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Film3.Models;

namespace Film3.Service
{
    public class UserService<T> : IDataService<T> where T : Human, new()
    {
        static readonly string sqlConnect = "Host=localhost;Port=5432;Username=postgres;Password=5432;Database=postgres";;
        private string ConnectionString { get; set; }

        public void Save(T human)
        {
            using (var conn = new SqlConnection(sqlConnect))
            {
                conn.Open();

                using (var cmd = new SqlCommand("Select * from Clients", conn))
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO users(name, lastname, date_current, sender_id) VALUES (@name, @lastname, @date_current, @sender_id)";
                    cmd.Parameters.AddWithValue("@name", human.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", human.LastName);
                    cmd.Parameters.AddWithValue("@date_current", human.Date);
                    cmd.Parameters.AddWithValue("@sender_id", human.SenderId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            var result = new List<T>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT sender_id, name,lastname,date_current FROM users";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        T entity = new T();
                        entity.SenderId = int.Parse(reader[0].ToString());
                        entity.Name = reader[1].ToString();
                        entity.LastName = reader[2].ToString();
                        entity.Date = Convert.ToDateTime(reader[3].ToString());
                        result.Add(entity);
                    }
                }

                return result;
            }
        }
    }
}