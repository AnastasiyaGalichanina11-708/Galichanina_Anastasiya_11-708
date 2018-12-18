using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Film3.Service
{
    class FileService<T> : IDataService<T> where T : Photo, new()
    {
        //заменить базу данных
        static readonly string SqlConnection = "Host=localhost;Port=5432;Username=postgres;Password=5432;Database=postgres";
       // private string ConnectionString { get; set; }

        public void Save(T file)
        {
            using (var conn = new SqlConnection(SqlConnection))
            {
                conn.Open();
               
                using (var command = new SqlCommand("Select * from Clients", conn))
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO photo(path,date_create,user_id) VALUES (@path, @date_create, @user_id)";
                    command.Parameters.AddWithValue("@path", file.Path);
                    command.Parameters.AddWithValue("@date_create", file.DateCreate);
                    command.Parameters.AddWithValue("@user_id", file.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            var result = new List<T>();
            using (var conn = new SqlConnection(SqlConnection))
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM photo";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        T entity = new T
                        {
                            UserId = int.Parse(reader[0].ToString()),
                            Path = reader[1].ToString(),
                            DateCreate = Convert.ToDateTime(reader[3].ToString())
                        };
                        result.Add(entity);
                    }
                }

                return result;
            }
        }
    }
}
