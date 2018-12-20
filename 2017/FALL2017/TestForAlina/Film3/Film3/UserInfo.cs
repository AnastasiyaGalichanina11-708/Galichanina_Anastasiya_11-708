using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Film3.Models;


namespace Film3
{
    public class UserInfo
    {
        public Human Human { get; set; }
        public int Step { get; set; }
        public Photo Photo { get; set; }
        public Emotion Emotion { get; set; }
    }
}