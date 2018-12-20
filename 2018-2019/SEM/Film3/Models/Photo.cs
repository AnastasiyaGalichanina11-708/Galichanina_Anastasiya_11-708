using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Film3.Models
{
    public class Photo
    {
        public string Path { get; set; }
        public DateTime DateCreate { get; set; }
        public int UserId { get; set; }
    }
}