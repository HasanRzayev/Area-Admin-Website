using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using UltraWebsite.Data;
using UltraWebsite.Models;

namespace UltraWebsite.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext baza;
        public HomeController(AppDbContext context)
        {
            baza = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            ViewBag.Tags = baza.Tags.ToList();
            return View(await baza.Products.Include(p => p.Catalogue).ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View(baza.Products.ToList());
        }


        [HttpPost]
        public async Task<IActionResult> Shop(string? pattern)
        {
            var list = await baza.Products.Where(p => p.Name.Contains(pattern)).ToListAsync();
            return View(list);
        }

        //public async Task<IActionResult> Shop(int? id)
        //{
        //    var list = await baza.ProductTags.Include(pt => pt.Product).Where(pt => pt.TagId == id).Select(pt => pt.Product).ToListAsync();

        //    return View(list);
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}