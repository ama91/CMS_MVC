using CustomerManagementSystem.Data;
using CustomerManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementSystem.Controllers
{
    public class MerchantCategoryController : Controller
    {
        private ApplicationDbContext _db;

        public MerchantCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<MerchantCategory> objMerchantCategoryList = _db.MerchantCategories.ToList();

            return View(objMerchantCategoryList);
        }
    }
}
