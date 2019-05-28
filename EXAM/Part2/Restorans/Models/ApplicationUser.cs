using System.Collections.Generic;
using Restorans.Models;
using Microsoft.AspNetCore.Identity;

namespace Restorans.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImagePath { get; set; }
        
        public List<Dish> Recipes { get; set; }

        public int Balance { get; set; }
    }
}