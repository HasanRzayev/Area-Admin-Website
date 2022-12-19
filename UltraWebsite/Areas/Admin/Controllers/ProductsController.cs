using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UltraWebsite.Data;
using UltraWebsite.Helpers;
using UltraWebsite.Models.Entity;
using UltraWebsite.Models.ViewModels;

namespace UltraWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {

      
        private AppDbContext baza;
        public ProductsController(AppDbContext context)
        {
            baza = context;
        }

        public IActionResult Menu_Catagory()
        {
            var produtcs = new List<Catagory>();
            foreach (var ct in baza.Catalogues.ToList())
            {
                produtcs.Add(new Catagory()
                {
                    Id = ct.Id,
                    Name = ct.Name,
                });
            }

            return View(produtcs);
        }

        [HttpGet]
        public IActionResult AddCatagory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCatagory(Catagory catalogue)
        {
            if (!ModelState.IsValid)
            {

                Catagory lazim = new Catagory();
                lazim.Name = catalogue.Name;
                baza.Catalogues.Add(lazim);
                baza.SaveChanges();

                return RedirectToAction("Menu_Catagory");
            }
            return View();

        }


        public ActionResult Delete(int Id)
        {
            //var lazim = baza.Products.ToList().Find(p => p.catalogue_id == Id);
            //if (baza.Products.First())
            //{
                    
            //}
            baza.Catalogues.Remove(baza.Catalogues.ToList().Find(p => p.Id == Id));
            baza.SaveChanges();
            return RedirectToAction("Menu_Catagory");
        }

        public IActionResult UpdateCatagory(int Id)
        {
            var lazim = (baza.Catalogues.ToList().Find(p => p.Id == Id));
            ViewBag.nomre = Id;
            return View(lazim);
        }
        [HttpPost, ActionName("UpdateCatagory")]
        public IActionResult UpdateCatagory(Catagory catalogue)
        {

            if (catalogue.Name != null)
            {

                Catagory lazim = baza.Catalogues.Find(catalogue.Id);
                lazim.Name = catalogue.Name;
                baza.SaveChanges();
            }
            return RedirectToAction("Menu_Catagory");
        }


        public IActionResult Menu_Product()
        {

            var model = baza.Catalogues.Include(a => a.Products).ToList();
            var produtcs = new List<Product>();
            foreach (var ct in baza.Products.ToList())
            {
                produtcs.Add(new Product()
                {
                    Id = ct.Id,
                    Name = ct.Name,
                    price = ct.price,
                    Catalogue = ct.Catalogue,
                });
            }

            return View(produtcs);
        }
        public ActionResult DeleteProduct(int Id)
        {

            baza.Products.Remove(baza.Products.ToList().Find(p => p.Id == Id));
            baza.SaveChanges();
            return RedirectToAction("Menu_Product");
        }
        public IActionResult AddProduct()
        {
            
            ViewBag.Categories = new SelectList(baza.Catalogues, "Id", "Name");
           
            return View();
        }
        [HttpPost, ActionName("AddProduct")]
        public async Task<IActionResult> AddProduct(AddProductViewModel product)
        {
            var path = await UploadFileHelper.UploadFile(product.Image_url);
            if (product.Name != null)
            {
                Product lazim = new Product();
                lazim.Name = product.Name;
                lazim.catalogue_id = product.catalogue_id;
                lazim.price = product.price;    
                lazim.ProductMaterial=product.ProductMaterial;
                lazim.ProductAdjective=product.ProductAdjective;
                lazim.Color=product.Color;
                lazim.Image_url = path;
                baza.Products.Add(lazim);
                baza.SaveChanges();
                foreach (var tag in product?.TagIds)
                {
                    baza.ProductTags.Add(new ProductTag { TagId = tag, ProductId = lazim.Id });
                }                         
                baza.SaveChangesAsync();

            }
            return RedirectToAction("Menu_Product");

        }

        public IActionResult UpdateProduct(int Id)
        {
            var lazim = (baza.Products.ToList().Find(p => p.Id == Id));
            ViewBag.nomre = Id;
            ViewBag.Categories = new SelectList(baza.Catalogues, "Id", "Name");
            return View(lazim);
        }
        [HttpPost, ActionName("UpdateProduct")]
        public IActionResult UpdateProduct(Product product) 
        {

            if (product.Name != null)
            {

                Product lazim = baza.Products.Find(product.Id);
                lazim.Name = product.Name;
                lazim.catalogue_id = product. catalogue_id;
                baza.SaveChanges();
            }
            return RedirectToAction("Menu_Product");
        }

        //public IActionResult Index()
        //{
        //    return RedirectToActionPermanent("Index","Home");
        //}
    }
}
