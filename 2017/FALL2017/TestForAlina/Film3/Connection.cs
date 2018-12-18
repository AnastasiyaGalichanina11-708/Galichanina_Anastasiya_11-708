using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using Film3.Models;

namespace Film3
{
    public class Connection
    {
        // Заменить базу данных
        static readonly string SqlConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\App_Data\Shop.mdf;Integrated Security=True";

        public static int Id { get; set; }
        public static string Choose { get; set; }

        public static List<Client> GetClients()
        {
            List<Client> listCl = new List<Client>();
            SqlConnection conn = new SqlConnection(SqlConnection);
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Clients", conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Client client = new Client();
                    client.Id = reader.GetInt32(0);
                    client.Password = reader.GetValue(1).ToString();                    
                    listCl.Add(client);
                }
            }
            reader.Close();
            conn.Close();
            return listCl;
        }

        public static List<Film> GetGoods()
        {
            List<Film> listF = new List<Film>();
            SqlConnection conn = new SqlConnection(SqlConnection);
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Goods", conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Film film = new Film();
                    film.Id = reader.GetInt32(0);
                    film.Name = reader.GetValue(1).ToString();
                    film.Link = reader.GetValue(2).ToString();
                    film.OtherInf = reader.GetValue(3).ToString();
                    film.Mood = reader.GetValue(4).ToString();
                    listF.Add(film);
                }
            }
            reader.Close();
            conn.Close();
            return listF;
        }

        // Если делаешь сложгый запрос SQL нужно отлавливать ошибки


        //public static List<ShopBusket> GetShopBusket()
        //{
        //    List<ShopBusket> list = new List<ShopBusket>();
        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(SqlConnection);
        //        conn.Open();
        //        SqlCommand command = new SqlCommand("Select s.Id,g.Name,g.Price,g.Manufacturer,s.ClientId,s.NumberOfGood,s.OrderDate from  ShopBusket s INNER JOIN Goods g ON s.GoodId = g.Id", conn);
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                ShopBusket shopBusket = new ShopBusket();
        //                shopBusket.Id = reader.GetInt32(0);
        //                shopBusket.Name = reader.GetValue(1).ToString();
        //                shopBusket.Price = reader.GetValue(2).ToString();
        //                shopBusket.Manufacturer = reader.GetValue(3).ToString();
        //                shopBusket.ClientId = reader.GetInt32(4);
        //                shopBusket.NumberOfGood = reader.GetInt32(5);
        //                shopBusket.OrderDate = reader.GetValue(6).ToString();
        //                list.Add(shopBusket);
        //            }
        //        }
        //        reader.Close();
        //        conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Connection:\n" + ex.Message, "Ошибка!");
        //    }
        //    return list;
        //}
    }
}