using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Instagram.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        //Текст комментария
        public string Text { get; set; }
        // Тот, кто комментирует (его ник)
        public string Сommentator { get; set; }
    }
}