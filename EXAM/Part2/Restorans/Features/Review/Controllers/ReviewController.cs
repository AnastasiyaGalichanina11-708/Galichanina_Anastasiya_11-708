using System.Linq;
using Restorans.Managers.DatabaseManager;
using Restorans.Managers.PaymentsManager;
using Restorans.Models;
using Restorans.Features.MainPage.Models;
using Restorans.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restorans.Features.Review.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ReviewController : Controller
    {
        private readonly IDatabaseManager _databaseManager;
        private readonly IPaymentsManager _paymentsManager;

        public ReviewController(IDatabaseManager databaseManager, IPaymentsManager paymentsManager)
        {
            _databaseManager = databaseManager;
            _paymentsManager = paymentsManager;
        }

        public IActionResult Review(int page=1)
        {
            const int pageSize = 7;
            var source = _databaseManager.GetRecipesByStatus((int) RecipeStatus.Created);

            var count = source.Count;
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
 
            var pageViewModel = new PageViewModel(count, page, pageSize);
            var viewModel = new MainViewModel
            {
                PageViewModel = pageViewModel,
                Recipes = items
            };
            return View("~/Features/Review/Views/Review.cshtml", viewModel);
        }
        
        [HttpGet]
        public IActionResult Show(int id)
        {
            var post = _databaseManager.GetRecipe(id);
            ViewData["Article"] = post;
            return post == default(Dish) ? View("~/Features/Review/Views/Review.cshtml") : View("~/Features/Review/Views/ReviewRecipe.cshtml", post);
        }
        
        [HttpPost]
        public ActionResult ApproveRecipe(int id, string userName, int score)
        {
            if (!ModelState.IsValid || score < 100 && score > 500) 
                return RedirectToAction("Review", "Review");
            
            _paymentsManager.SellRecipe(id, score, userName);

            return _databaseManager.GetRecipesByStatus((int)RecipeStatus.Created).Count == 0
                ? RedirectToAction("Home", "Main") 
                : RedirectToAction("Review", "Review");

        }

        [HttpPost]
        public ActionResult DeclineRecipe(string content, int articleId)
        {
            if (!ModelState.IsValid) return RedirectToAction("Review", "Review");
            
            _databaseManager.DeclineRecipe(content, articleId);

            return RedirectToAction("Review", "Review");
        }
    }
}