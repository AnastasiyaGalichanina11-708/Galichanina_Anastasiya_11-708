using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Film3.Service;
using Film3.Models;

namespace Film3
{
    public class Program
    {
        public static Dictionary<int, UserInfo> UserInfos;
        public static UserService<Human> Service;
        private static FileService<Photo> PhotoService;

        public static void Initialization(string name, string lastName)
        {
            Service = new UserService<Human>();
            PhotoService = new FileService<Photo>();
            UserInfos = new Dictionary<int, UserInfo>();
            var dateCurrent = DateTime.Today;
            var listPeople = Service.GetAll();
            int senderId = UserInfos.Count;
            UserInfos.TryGetValue(senderId, out var userInfo);       

            if (userInfo == null)
            {
                userInfo = new UserInfo
                {
                    Emotion = new Emotion(),
                    Human = new Human(),
                    Step = 0,
                    Photo=new Photo()
                };

                UserInfos.Add(senderId, userInfo);
                userInfo.Human.SenderId = senderId;
                userInfo.Human.Date = dateCurrent;                
            }

            userInfo.Human.FirstName = name;
            userInfo.Human.LastName = lastName;
            
        }
       
    }
}