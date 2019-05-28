using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Restorans.Data;
using Restorans.Features.UserData.Models;
using Restorans.Models;
using Restorans.Managers.DatabaseManager;
using Restorans.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Restorans.Features.UserData.Controllers
{
    public class AccountController : Controller
    {
        private readonly IDatabaseManager _databaseManager;

        public AccountController(IDatabaseManager databaseManager) => 
            _databaseManager = databaseManager;

        [Authorize]
        [HttpGet]
        public ActionResult Profile()
        {
            ViewData["User"] = _databaseManager.GetUser(User.Identity.Name);
            return View("~/Features/UserData/Views/Profile.cshtml",_databaseManager.GetUserRecipes(User.Identity.Name));
        }
        
        [HttpGet]
        [Route("OtherProfile/{email}")]
        [Route("[controller]/[action]/{email}")]
        public ActionResult OtherProfile(string email)
        {
            ViewData["User"] = _databaseManager.GetUser(email);
            return View("~/Features/UserData/Views/OtherProfile.cshtml",_databaseManager.GetUserRecipes(email));
        }

        public ActionResult Article(Dish articleModel) => View("~/Features/Shared/Article.cshtml",articleModel);

        public ActionResult CreateRecipe()
        {
            var selectedList = new List<SelectListItem>();
            foreach (var cuisine in _databaseManager.GetAllCuisines())
            {
                selectedList.Add(new SelectListItem { Text = cuisine.Name, Value = cuisine.Id.ToString()});
            }
            var createArticleViewModel = new CreateRecipeViewModel { Recipe = new Dish(), Cuisines = selectedList };
                
            return View("~/Features/UserData/Views/CreateRecipe.cshtml", createArticleViewModel);  
        } 
        
        
        [HttpPost]
        public ActionResult CreateRecipe(Dish recipe, string category, string cuisineId, IFormFile imageFile)
        {
            if (!ModelState.IsValid) return View("~/Features/UserData/Views/CreateRecipe.cshtml");
            
            var currentUser = _databaseManager.GetUser(User.Identity.Name);
            
            if (currentUser == default(ApplicationUser))
                return RedirectToAction("Profile");
            
            recipe.Username = User.Identity.Name;
            recipe.User = currentUser;
            recipe.Category = Enum.Parse(typeof(Category), category).ToString();
            recipe.Status = (int)RecipeStatus.Created;
            recipe.CreationDate = DateTime.Now.ToBinary();
            recipe.Cuisine = int.Parse(cuisineId);
            
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = imageFile.FileName;
                var extension = Path.GetExtension(fileName);
                if (extension == ".png" || extension == ".jpg")
                {
                    var filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images"));
                    using (var fileStream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }
                    recipe.ImagePath = "~/images/"+ fileName;
                }
            }
            
            _databaseManager.AddRecipe(recipe);

            return RedirectToAction("Profile"); 
        }
        
        [HttpGet]
        public ActionResult EditUser()
        {
            var user = _databaseManager.GetUser(User.Identity.Name);
            return View("~/Features/UserData/Views/EditUser.cshtml", user);
        }
        
        [HttpGet]
        public ActionResult OnReview(int id)
        {
            _databaseManager.EditRecipeStatus(_databaseManager.GetRecipe(id), (int)RecipeStatus.Created);
            return RedirectToAction("Profile");
        }
        
        [HttpPost]
        public ActionResult EditUser(ApplicationUser clientModel, IFormFile imageFile)
        {
            if (!ModelState.IsValid) return View("~/Features/UserData/Views/EditUser.cshtml");
            if (imageFile != null && imageFile.Length > 0)
            {
                var fileName = imageFile.FileName;
                var extension = Path.GetExtension(fileName);
                if (extension == ".png" || extension == ".jpg")
                {
                    var filePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images"));
                    using (var fileStream = new FileStream(Path.Combine(filePath, fileName), FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }

                    clientModel.ImagePath = "~/images/"+ fileName;
                }
            }
            _databaseManager.EditUser(User.Identity.Name, clientModel);

            return RedirectToAction("Profile");
        }
        
        public ActionResult EditRecipe(int id) => View("~/Features/UserData/Views/EditRecipe.cshtml",_databaseManager.GetRecipe(id));
        
        [HttpPost]
        public ActionResult EditRecipe(Dish recipe)
        {
            if (!ModelState.IsValid) return View("~/Features/UserData/Views/EditRecipe.cshtml");
            _databaseManager.EditRecipe(recipe);

            return RedirectToAction("Profile", "Account");
        }

        public ActionResult Delete(int id)
        {
            var isAdmin = User.IsInRole("Admin");
            _databaseManager.DeleteRecipe(id, isAdmin, User.Identity.Name);

            return RedirectToAction("Home", "Main");
        }

        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
    }
}