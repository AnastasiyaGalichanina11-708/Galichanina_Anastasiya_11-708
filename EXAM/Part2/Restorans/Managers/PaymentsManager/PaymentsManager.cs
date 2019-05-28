using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Restorans.Managers.AuthManager;
using Restorans.Managers.DatabaseManager;
using Restorans.Models;

namespace Restorans.Managers.PaymentsManager
{
    public class PaymentsManager: IPaymentsManager
    {
        private readonly IDatabaseManager _databaseManager;
        private readonly IAuthManager _authManager;

        public PaymentsManager(IDatabaseManager databaseManager, IAuthManager authManager)
        {
            _databaseManager = databaseManager;
            _authManager = authManager;
        }

        public List<Cuisine> GetAvailableCuisines(string userEmail)
        {
            var user = _databaseManager.GetUser(userEmail);
            var balance = user.Balance;
            var allCuisine = _databaseManager.GetAllCuisines().Where(c => c.Price <= balance);
            var purCuisine = GetPurchasedCuisines(userEmail);
            return allCuisine.Except(purCuisine).ToList();
        }
        
        public List<Cuisine> GetUnavailableCuisines(string userEmail)
        {
            var user = _databaseManager.GetUser(userEmail);
            var balance = user.Balance;
            var allCuisine = _databaseManager.GetAllCuisines().Where(c => c.Price > balance);
            var purCuisine = GetPurchasedCuisines(userEmail);
            return allCuisine.Except(purCuisine).ToList();
        }

        public List<Cuisine> GetPurchasedCuisines(string userEmail)
        {
            var user = _databaseManager.GetUser(userEmail);
            var purchasedHistory = _databaseManager.GetPurchasedCuisines(user.Id);
            var result = new List<Cuisine>();
            foreach (var purchase in purchasedHistory)
            {
                result.Add(_databaseManager.GetCuisine(purchase.CuisineId));
            }
            return result;
        }

        public void BuyCuisine(ClaimsPrincipal userEmail, int cuisineId)
        {
            var user = _databaseManager.GetUser(userEmail.Identity.Name);
            var cuisine = _databaseManager.GetCuisine(cuisineId);
            if (user.Balance >= cuisine.Price)
            {
                _databaseManager.AddCuisineToUser(user.Id, cuisineId);
                _databaseManager.EditBalance(userEmail.Identity.Name, user.Balance - cuisine.Price);
                _authManager.UpdateClaim(userEmail);
            }
            
        }
        
        public void SellRecipe(int id, int score, string userName)
        {
            _databaseManager.ApproveRecipe(id);
            _databaseManager.AddScore(score, userName);
        }

        public bool IsPurchasedCuisine(string userEmail, int cuisineId)
        {
            var purchased = GetPurchasedCuisines(userEmail).FirstOrDefault(c => c.Id == cuisineId);
            if (purchased == default(Cuisine))
                return false;
            return true;
        }
    }
}