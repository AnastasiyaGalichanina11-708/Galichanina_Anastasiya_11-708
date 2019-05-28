using System;
using System.Linq;
using Restorans.Data;
using Restorans.Managers.DatabaseManager;
using Restorans.Managers.PaymentsManager;
using Restorans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Restorans.Features.Cuisines
{
    public class CuisinesController : Controller
    {
        private readonly IPaymentsManager _paymentsManager;

        public CuisinesController(IPaymentsManager paymentsManager) =>
            _paymentsManager = paymentsManager;

        public IActionResult List()
        {
            try
            {
                var cuisines = new CuisineViewModel
                {
                    AvailableCuisines = _paymentsManager.GetAvailableCuisines(User.Identity.Name),
                    UnavailableCuisines = _paymentsManager.GetUnavailableCuisines(User.Identity.Name),
                    PurchasedCuisines = _paymentsManager.GetPurchasedCuisines(User.Identity.Name)
                };
                return View("~/Features/Cuisines/List.cshtml", cuisines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction("Home", "Main");
            }
        }

        //public IActionResult Add();

        public IActionResult Buy(int id)
        {
            _paymentsManager.BuyCuisine(User, id);
            return RedirectToAction("List", "Cuisines");
        }
    }
}