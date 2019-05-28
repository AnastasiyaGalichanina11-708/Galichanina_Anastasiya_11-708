using System.Collections.Generic;
using Restorans.Features.Identity.Models;

namespace Restorans.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public int Status { get; set; }
        public long CreationDate { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public int Cuisine { get; set; }
        
        public string Username { get; set; }
        
        public string DeclineComment { get; set; }
        
        public List<Like> Likes { get; set; }
        public List<Comment> Comments { get; set; }
        public ApplicationUser User { get; set; }
    }
}