using System.Collections.Generic;
using Restorans.Models;

namespace Restorans.Features.Search.Models
{
    public class SearchViewModel
    {
        public string SearchString { get; set; }
        public List<Dish> SearchResult { get; set; }
    }
}