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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MerchantCategory obj)
        {
            if (ModelState.IsValid)
            { 
                _db.MerchantCategories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
