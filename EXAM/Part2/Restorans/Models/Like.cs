using Restorans.Features.Identity.Models;

namespace Restorans.Models
{
    public class Like
    {
        public int Id { get; set; }
        public bool IsLike{ get; set; }
        
        public int RecipeId { get; set; }
        public Dish Recipes { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser Users { get; set; }
    }
}