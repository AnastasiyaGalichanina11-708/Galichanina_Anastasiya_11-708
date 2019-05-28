using System.Collections.Generic;
using System.Security.Claims;
using Restorans.Models;

namespace Restorans.Managers.PaymentsManager
{
    public interface IPaymentsManager
    {
        List<Cuisine> GetAvailableCuisines(string userEmail);
        List<Cuisine> GetUnavailableCuisines(string userEmail);

        List<Cuisine> GetPurchasedCuisines(string userEmail);

        void BuyCuisine(ClaimsPrincipal userEmail, int cuisineId);

        bool IsPurchasedCuisine(string userEmail, int cuisineId);

        void SellRecipe(int id, int score, string userName);
    }
}