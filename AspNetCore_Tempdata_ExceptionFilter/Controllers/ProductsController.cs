using AspNetCore_Tempdata_ExceptionFilter.CustomProviders;
using AspNetCore_Tempdata_ExceptionFilter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_Tempdata_ExceptionFilter.Controllers
{
    public class ProductController : Controller
    {
        Products prds;
        Categories cats;
        public ProductController()
        {
            prds = new Products();
            cats = new Categories();
        }
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();
            if (TempData.Values.Count > 0)
            {
                var catid = Convert.ToInt32(TempData["CatId"]);
                products = (from p in prds
                           where p.CategoryId == catid
                            select p).ToList();
               return View(products);
            }
            return View(prds);
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(cats, "CategoryId", "CategoryName");
            if (TempData.Values.Count > 0)
            {
                Product prdData = TempData.GetData<Product>("Prd") as Product;
                return View(prdData);
            }
            var prd = new Product();
            return View(prd);
        }

        [HttpPost]
        public IActionResult Create(Product prd)
        {
            if (ModelState.IsValid)
            {
                if (prd.Price < 0)
                {
                    TempData.SetData<Product>("Prd", prd);
                    throw new Exception("Price can not be -ve");
                }

                prds.Add(prd);
                return RedirectToAction("Index");    
            }
            return View(prd);
        }

    }
}