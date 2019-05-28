﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class File
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }
        public long CreationDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string ShortComment { get; set; }
        public string Username { get; set; }



        //public int Status { get; set; }

        //public string Ingredients { get; set; }

        //public string Category { get; set; }
        //public int Cuisine { get; set; }


        //public string DeclineComment { get; set; }

        //public List<Like> Likes { get; set; }
        //public List<Comment> Comments { get; set; }

    }
}