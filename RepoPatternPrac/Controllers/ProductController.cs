using Microsoft.AspNetCore.Mvc;
using RepoPatternPrac.Models;
using RepoPatternPrac.Repo;

namespace RepoPatternPrac.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepo repo;
        public ProductController(ProductRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var dt = repo.GetAll();
            return View(dt);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Products p)
        {
            repo.AddProd(p);
            TempData["msg"] = "Product Added Successfully";
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProd(int id)
        {
            repo.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult EditProd(int id)
        { 
           var data =  repo.GetById(id);
            if (data == null)
            {
                return NotFound("Not Found");
            }
            return View(data);
        }
        [HttpPost]
        public IActionResult EditProd(Products p)
        {
           if(ModelState.IsValid)
            {
                repo.Update(p);
                TempData["Edit"] = "Update Product Successfully";
                return RedirectToAction("Index");
            }
           return View(p);
        }
    }
}
