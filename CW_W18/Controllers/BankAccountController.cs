using CW_W18.Models;
using Microsoft.AspNetCore.Mvc;

namespace CW_W18.Controllers
{
    public class BankAccountController : Controller
    {
        private static BankAccount account = new BankAccount(1000);
        public IActionResult Index()
        {
            ViewBag.Balance = account.Balance;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> WithDraw(decimal amount)
        {
            bool success = await account.WithDrawAsync(amount);
            if (success)
            {
                ViewBag.Message = $"SuccessFully Withdraw {amount}";
            }
            else
            {
                ViewBag.Message = $"failed to Withdraw {amount}";

            }
            ViewBag.Balance = account.Balance;
            return View("Index");
        }
    }
}
