using System.Collections.Generic;
using Restorans.Models;

namespace Restorans.Features.Cuisines
{
    public class CuisineViewModel
    {
        public IEnumerable<Cuisine> AvailableCuisines { get; set; }

        public IEnumerable<Cuisine> UnavailableCuisines { get; set; }

        public IEnumerable<Cuisine> PurchasedCuisines { get; set; }
    }
}