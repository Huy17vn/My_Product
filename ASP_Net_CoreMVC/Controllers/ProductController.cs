using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Net_CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Net_CoreMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly DBContext _context;

        public ProductController(DBContext _context)

        {
           

            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product()
                {
                    Name = "Minh",
                    Price = 200,
                });

                _context.Products.Add(new Product()
                {
                    Name = "Huy",
                    Price = 4000,
                });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int Id)
        {
            var exisProduct = _context.Products.Find(Id);
            if (exisProduct == null)
            {
                return NotFound();
            }
            return View(exisProduct);
        }
        public IActionResult Update(Product product)
        {
            var exisProduct = _context.Products.Find(product.Id);
            if (exisProduct == null)
            {
                return NotFound();
            }
            exisProduct.Name = product.Name;
            exisProduct.Price = product.Price;
            _context.Products.Update(exisProduct);
            _context.SaveChanges();
            TempData["message"] = "Update success";
            return new RedirectResult("GetList");
        }

       
              [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var exisProduct = _context.Products.Find(Id);
            if (exisProduct == null)
            {
                return NotFound();
            }
            _context.Products.Remove(exisProduct);
            _context.SaveChanges();
            return new RedirectResult("GetList");
        }
    }

  
}