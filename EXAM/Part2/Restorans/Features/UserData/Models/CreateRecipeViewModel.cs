using System.Collections.Generic;
using Restorans.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restorans.Features.UserData.Models
{
    public class CreateRecipeViewModel
    {
        public List<SelectListItem> Cuisines { get; set; }
        public Dish Recipe { get; set; }
    }
}