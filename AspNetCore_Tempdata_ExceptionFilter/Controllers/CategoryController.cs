using AspNetCore_Tempdata_ExceptionFilter.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Tempdata_ExceptionFilter.Controllers
{
    public class CategoryController : Controller
    {
        Categories cats;
        public CategoryController()
        {
            cats = new Categories(); 
        }
        public IActionResult Index()
        {
            
            return View(cats);
        }

        public IActionResult Details(int id)
        {
            TempData["CatId"] = id;
            return RedirectToAction("Index", "Product");
        }

    }
}