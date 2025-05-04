using JqueryAjaxKullanimi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JqueryAjaxKullanimi.Controllers
{
    public class ProductController : Controller
    {
        AjaxTestModel db = new AjaxTestModel();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetProduct()
        {
            List<Product> products = db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PostProduct(string name, string description, double price)
        {
            try
            {
                db.Products.Add(new Product() { Name = name, Description = description, Price = price });
                db.SaveChanges();
                return Json("1", JsonRequestBehavior.AllowGet);
            }
            catch (System.Exception)
            {

                return Json("0", JsonRequestBehavior.AllowGet);
            }
        }
    }
}