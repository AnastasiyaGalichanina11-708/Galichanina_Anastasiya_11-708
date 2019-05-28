using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Restorans.Managers.DatabaseManager;
using Restorans.Managers.PaymentsManager;
using Microsoft.AspNetCore.Mvc;
using Restorans.Models;
using Restorans.Features.MainPage.Models;
using Restorans.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restorans.Features.MainPage.Controllers
{
    public class MainController : Controller
    {
        private readonly IDatabaseManager _databaseManager;
        private readonly IPaymentsManager _paymentsManager;

        public MainController(IDatabaseManager databaseManager, IPaymentsManager paymentsManager)
        {
            _databaseManager = databaseManager;
            _paymentsManager = paymentsManager;
        }

        public IActionResult Home(Category? categoryId, int? cuisineId, int page=1)
        {
            const int pageSize = 7;
            var selectedList = new List<SelectListItem>();
            
            var cuisines = User.Identity.IsAuthenticated
                ? _databaseManager.GetUserCuisines(User.Identity.Name)
                : new List<Cuisine> {_databaseManager.GetCuisine(1) };
            
            foreach (var cuisine in cuisines)
                selectedList.Add(new SelectListItem { Text = cuisine.Name, Value = cuisine.Id.ToString()});

            //ViewData["Cuisines"] = selectedList;
            
            var source =_databaseManager.GetRecipeByCategoryAndCuisine(categoryId, cuisineId, User.Identity.Name);
            var count = source.Count;
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
 
            var pageViewModel = new PageViewModel(count, page, pageSize);
            var viewModel = new MainViewModel
            {
                PageViewModel = pageViewModel,
                Recipes = items,
                UserCuisines = selectedList
            };
            
            return View("~/Features/MainPage/Views/Home.cshtml",viewModel);
        }
        
        [HttpPost]
        public IActionResult ShowCuisine(int id)
        {
            if (!_paymentsManager.IsPurchasedCuisine(User.Identity.Name, id))
                return RedirectToAction("Home");
            return View("~/Features/MainPage/Views/ShowCuisine.cshtml",_databaseManager.GetCuisineRecipes(id));
        }
      
        public ActionResult Article(Dish articleModel) => View("~/Features/Shared/Article.cshtml", articleModel);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View("~/Features/Shared/Error.cshtml", new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        
    }
}