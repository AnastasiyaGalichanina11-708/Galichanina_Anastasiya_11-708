using System;
using System.Collections.Generic;
using Restorans.Features.Search.Models;
using Restorans.Managers.DatabaseManager;
using Restorans.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restorans.Features.Search.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        
        private readonly IDatabaseManager _databaseManager;
        
        public SearchController(IDatabaseManager databaseManager) => _databaseManager = databaseManager;

        public IActionResult SearchPage()
        {
            var emptyModel = new SearchViewModel {SearchString = "", SearchResult = new List<Dish>()};
            return View("~/Features/Search/Views/SearchPage.cshtml", emptyModel);
        }

        [HttpPost]
        public IActionResult SearchPage(string searchString)
        {
            Console.WriteLine(searchString);
            var currentUser = _databaseManager.GetUser(User.Identity.Name);
            var cuisines = _databaseManager.GetPurchasedCuisines(currentUser.Id);
            var resultRecipes = new List<Dish>();

            foreach (var cuisine in cuisines)
            {
                var recipes = _databaseManager.GetCuisineRecipes(cuisine.CuisineId);
                foreach (var recipe in recipes)
                {
                    if (recipe.Title.Contains(searchString) 
                        || recipe.Content.Contains(searchString) 
                        || recipe.Ingredients.Contains(searchString))
                    resultRecipes.Add(recipe);
                }
            }
            
            var searchViewModel = new SearchViewModel {SearchString = "", SearchResult = resultRecipes}; 
            return View("~/Features/Search/Views/SearchPage.cshtml", searchViewModel);
        }
        
    }
}