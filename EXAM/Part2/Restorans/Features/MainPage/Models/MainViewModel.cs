using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restorans.Models;

namespace Restorans.Features.MainPage.Models
{
    public class MainViewModel
    {
        public IEnumerable<Dish> Recipes { get; set; }
        public PageViewModel PageViewModel { get; set; }
        
        public List<SelectListItem> UserCuisines { get; set; }
    }
}