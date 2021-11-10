using Data.DataDb;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Visual()
        //{
        //    return Json(ProList());
        //}
        //public List<Product> ProList()
        //{
        //    List<Product> pr = new List<Product>();

        //}
        public IActionResult Index2()
        {
            return View();

        }
        public IActionResult Visual1()
        {
            return Json(ProductList());
        }
        public List<Chart> ProductList()
        {
            List<Chart> ct = new List<Chart>();
            using (var c = new StockTrackingDbContext())
            {
                ct = c.Products.Select(x => new Chart
                {
                    Name = x.ProductName,
                    Stock = x.ProductStock
                }).ToList();
            }
            return ct;
        }
    }
}
