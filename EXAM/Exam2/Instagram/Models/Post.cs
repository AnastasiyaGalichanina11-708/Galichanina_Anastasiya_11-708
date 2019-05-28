using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public FileModel File { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
        
    }
}
