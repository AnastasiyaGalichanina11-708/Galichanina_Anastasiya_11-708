using System;
using System.Collections.Generic;
using System.Linq;
using Restorans.Data;
using Restorans.Features.Identity.Models;
using Restorans.Models;
using Restorans.Utils;
using Microsoft.EntityFrameworkCore;

namespace Restorans.Managers.DatabaseManager
{
    public class DatabaseManager
    {
        private readonly ApplicationDbContext _databaseContext;

        public DatabaseManager(ApplicationDbContext context) => _databaseContext = context;

        #region User

        public ApplicationUser GetUser(string email)
        {
            var user = _databaseContext.Users.FirstOrDefault(u => u.UserName == email);
            return user ?? throw new Exception("No user with given id");
        }

        public void EditUser(string email, ApplicationUser newUser)
        {
            var oldUser = GetUser(email);
            if (newUser.PhoneNumber != null)
                oldUser.PhoneNumber = newUser.PhoneNumber;
            if (newUser.ImagePath != null || newUser.ImagePath != string.Empty)
                oldUser.ImagePath = newUser.ImagePath;
            _databaseContext.SaveChanges();
        }

        public void EditBalance(string email, int newBalance)
        {
            var user = GetUser(email);
            user.Balance = newBalance;
            _databaseContext.SaveChanges();
        }

        public void AddScore(int score, string userName)
        {
            var user = GetUser(userName);
            user.Balance = user.Balance + score;
            _databaseContext.SaveChanges();
        }

        #endregion

        #region Recipe
        
        private List<Dish> GetRecipeByPredicate(Func<Dish, bool> predicate)
        {
            return _databaseContext
                .Dishes
                .Where(recipe => predicate(recipe))
                .OrderByDescending(article => article.CreationDate)
                .ToList();
        }
        public List<Dish> GetRecipesByStatus(int status) =>
            GetRecipeByPredicate(recipe =>
                recipe.Status == status);

        public List<Dish> GetRecipeByCategoryAndCuisine(Category? category, int? cuisineId, string userName)
        {
            if (cuisineId == null)
                cuisineId = 1;
            if (category != null)
                return GetRecipeByPredicate(recipe =>
                    recipe.Category == category.ToString() && recipe.Cuisine == cuisineId);
            return GetRecipeByPredicate(recipe => 
                recipe.Status == (int) RecipeStatus.Approved && recipe.Cuisine == cuisineId);
        }       

        public IEnumerable<Dish> GetUserRecipes(string userEmail) =>
            GetRecipeByPredicate(a => a.Username == userEmail);

        public Dish GetRecipe(int id)
        {
            var recipe = _databaseContext.Dishes.FirstOrDefault(a => a.Id == id);
            if (recipe == default(Dish)) 
                throw new Exception("No recipe with given id");
            return recipe;
        }

        public void AddRecipe(Dish recipe)
        {
            if (recipe == default(Dish)) 
                throw new Exception("No recipe with given id");
            _databaseContext.Dishes.Add(recipe);
            _databaseContext.SaveChanges();
        }

        public void EditRecipe(Dish recipe)
        {
            var oldRecipe = _databaseContext.Dishes.FirstOrDefault(a => a.Id == recipe.Id);
            if (oldRecipe == default(Dish))
                throw new Exception("No recipe with given id");
            oldRecipe.Title = recipe.Title;
            oldRecipe.Content = recipe.Content;
            oldRecipe.Ingredients = recipe.Ingredients;
            oldRecipe.Category = recipe.Category;
            oldRecipe.Status = (int)RecipeStatus.Created;
            _databaseContext.SaveChanges();
        }
        
        public void EditRecipeStatus(Dish recipe, int status)
        {
            recipe.Status = status;
            _databaseContext.SaveChanges();
        }

        public void DeleteRecipe(int id, bool isAdmin, string email)
        {
            var recipe = GetRecipe(id);
            if (recipe != default(Dish) && isAdmin || recipe != default(Dish))
            {
                _databaseContext.Dishes.Remove(recipe);
                _databaseContext.SaveChanges();
            }
        }

        public List<Dish> GetCuisineRecipes(int cuisineId)
        {
            return _databaseContext.Dishes
                .Where(r => r.Cuisine == cuisineId && r.Status == (int)RecipeStatus.Approved)
                .ToList();
        }

        #endregion
        
        

        #region Cuisines

        public Cuisine GetCuisine(int id)
        {
            var cuisine = _databaseContext.Cuisines.FirstOrDefault(c => c.Id == id);
            return cuisine ?? throw new Exception("No cuisine with such id");
        }

        public List<Cuisine> GetAllCuisines() => _databaseContext.Cuisines.ToList();

        public List<UserCuisine> GetPurchasedCuisines(string userId)
            => _databaseContext.UserCuisines.Where(p => p.UserId == userId).ToList();

        public List<Cuisine> GetUserCuisines(string userId)
        {
            var userCuisines = GetPurchasedCuisines(GetUser(userId).Id);
            var cuisines = new List<Cuisine>();
            foreach (var c in userCuisines)
                cuisines.Add(GetCuisine(c.CuisineId));
            return cuisines;
        }

        public void AddCuisineToUser(string userId, int cuisineId)
        {
            var userCuisine = new UserCuisine() {UserId = userId, CuisineId = cuisineId};
            _databaseContext.UserCuisines.Add(userCuisine);
            _databaseContext.SaveChanges();
        }

        public int GetDefaultCuisine()
        {
            return _databaseContext.Cuisines.FirstOrDefault(c => c.Price == 0).Id;
        }

        #endregion

        #region Review

        public void ApproveRecipe(int id)
        {
            var currentRecipe = _databaseContext.Dishes.FirstOrDefault(a => a.Id == id);
            if (currentRecipe == default(Dish))
                throw new Exception("No recipe with given id");
            currentRecipe.Status = (int)RecipeStatus.Approved;
            currentRecipe.DeclineComment = null;
            _databaseContext.SaveChanges();
        }

        public void DeclineRecipe(string comment, int id)
        {
            var currentRecipe = _databaseContext.Dishes.FirstOrDefault(a => a.Id == id);
            if (currentRecipe == default(Dish))
                throw new Exception("No recipe with given id");
            currentRecipe.Status = (int)RecipeStatus.Declined;
            currentRecipe.DeclineComment = comment;
            _databaseContext.SaveChanges();
        }

        #endregion

    }
}