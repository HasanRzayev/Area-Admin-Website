using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using UltraWebsite.Data;
using UltraWebsite.Helpers;
using UltraWebsite.Models;
using UltraWebsite.Models.Entity;
using UltraWebsite.Models.ViewModels;


namespace UltraWebsite.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly UserManager<AppUser> userManager;
        private AppDbContext baza;
        public HomeController(AppDbContext context, UserManager<AppUser> userManager)
        {
            baza = context;
            this.userManager = userManager;

        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Shop_details(Product pro)
        {
            ViewData["product"] = pro;
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
        public async Task<IActionResult> AddOrder(AddOrderViewModel model)
        {
            baza.SaveChanges();
            Order lazim = new Order();

            lazim.product_id = model.product_id;
           
            var claim = (ClaimsIdentity)User.Identity;
            var claims = claim.FindFirst(ClaimTypes.NameIdentifier);
            lazim.user_id = claims.Value;
            lazim.Count = model.Count;
 
            baza.Add(lazim);

            baza.SaveChanges();
            //lazim.Product = Model;
            ////lazim.Product = Model;

            //baza.Orders.Update(baza.Orders.FirstOrDefault(d => d.product_id == Model.Id));

            ////baza.Update(baza.Orders.FirstOrDefault(d => d.user_id == claims.Value));

            baza.SaveChanges();


            return RedirectToAction("Shop_details");

        }
        public ActionResult DeleteProduct(int Id)
        {

            baza.Orders.Remove(baza.Orders.ToList().Find(p => p.Id == Id));
            baza.SaveChanges();
            return RedirectToAction("Orders");
        }
        [HttpPost]
        public async Task<IActionResult> Shop(string? pattern)
        {
            var list = await baza.Products.Where(p => p.Name.Contains(pattern)).ToListAsync();
            return View(list);
        }
        
        public async Task<IActionResult> Orders()
        {
            var lazim = await baza.Orders.Include(p => p.Product).Include(a => a.user).ToListAsync();

            
            return View(lazim);
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