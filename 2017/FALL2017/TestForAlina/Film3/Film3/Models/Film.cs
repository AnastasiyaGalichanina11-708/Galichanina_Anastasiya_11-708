using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Film3.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string OtherInf { get; set; }
        public string Mood { get; set; }
    }
}