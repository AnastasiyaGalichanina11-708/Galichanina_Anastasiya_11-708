using System.Collections.Generic;
using Restorans.Features.Identity.Models;
using Restorans.Models;

namespace Restorans.Managers.DatabaseManager
{
    public interface IDatabaseManager
    {
        #region User

        ApplicationUser GetUser(string email);

        void EditUser(string email, ApplicationUser newUser);

        void EditBalance(string email, int newBalance);

        #endregion

        #region Recipe

        List<Dish> GetRecipeByCategoryAndCuisine(Category? category, int? cuisineId, string userName);
        
        List<Dish> GetRecipesByStatus(int status);

        IEnumerable<Dish> GetUserRecipes(string userEmail);

        Dish GetRecipe(int id);

        void AddRecipe(Dish recipe);

        void EditRecipe(Dish recipe);

        void DeleteRecipe(int id, bool isAdmin, string email);
        List<Dish> GetCuisineRecipes(int cuisineId);
        void EditRecipeStatus(Dish recipe, int status);

        void AddScore(int score, string userName);

        #endregion

        #region Comments

        List<Comment> GetComments(int recipeId);

        void AddComment(Comment comment);

        #endregion
        
        #region Review

        void ApproveRecipe(int id);

        void DeclineRecipe(string comment, int id);

        #endregion

        #region Cuisines

        List<Cuisine> GetUserCuisines(string userId);
        Cuisine GetCuisine(int id);

        List<Cuisine> GetAllCuisines();

        List<UserCuisine> GetPurchasedCuisines(string userId);

        void AddCuisineToUser(string userId, int cuisineId);

        int GetDefaultCuisine();

        #endregion

        #region Like

        int GetLikesCount(int id);
        string Like(int id, string userEmail);

        #endregion
    }
}