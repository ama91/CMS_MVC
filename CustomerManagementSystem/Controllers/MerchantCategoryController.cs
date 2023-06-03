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

                TempData["success"] = "Merchant category add successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int ? id)
        {
            if (id == null || id == 0)
                return NotFound();

            MerchantCategory? merchantCategory = _db.MerchantCategories.Find(id);

            if (merchantCategory == null)
                return NotFound();

            return View(merchantCategory);
        }

        [HttpPost]
        public IActionResult Edit(MerchantCategory obj)
        {

            if (ModelState.IsValid)
            {
                _db.MerchantCategories.Update(obj);
                _db.SaveChanges();

                TempData["success"] = "Merchant category Edited successfully";

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Susbend(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            MerchantCategory? merchantCategory = _db.MerchantCategories.Find(id);

            if (merchantCategory == null)
                return NotFound();

            return View(merchantCategory);
        }

        [HttpPost]
        public IActionResult Susbend(MerchantCategory obj)
        {
            if (obj == null)
                return NotFound();

            _db.MerchantCategories.Remove(obj);
            _db.SaveChanges();

            TempData["success"] = "Merchant category susbended successfully";

            return RedirectToAction("Index");
        }
    }
}
