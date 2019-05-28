using System.Collections.Generic;
using ExamPart2.Models;
using Microsoft.AspNetCore.Identity;
using ExamPart2.Models;

namespace ExamPart2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImagePath { get; set; }
        
        public List<Dish> Recipes { get; set; }

        public int Balance { get; set; }
    }
}