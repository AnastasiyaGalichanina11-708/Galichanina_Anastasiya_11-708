using System.Collections.Generic;
using Restorans.Features.Identity.Models;

namespace Restorans.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public long DateTime { get; set; }
        
        public int RecipeId { get; set; }
        public Dish Recipes { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser Users { get; set; }
    }
}