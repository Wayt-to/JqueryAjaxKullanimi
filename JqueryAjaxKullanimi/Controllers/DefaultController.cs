using JqueryAjaxKullanimi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JqueryAjaxKullanimi.Controllers
{
    public class DefaultController : Controller
    {
        AjaxTestModel db = new AjaxTestModel();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SehirGetir()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SehirIlceSec()
        {
            ViewBag.City_ID = new SelectList(db.Cities, "ID", "Name");
            ViewBag.County_ID = new SelectList(db.Counties.Where(x => x.City_ID == 1), "ID", "Name");
            return View();
        }

        public JsonResult LoadCounties(int cityid)
        {
            List<County> counties = db.Counties.Where(x => x.City_ID == cityid).ToList();
            var SelectListItems = counties.Select(x => new { ID = x.ID, Name = x.Name });
            return Json(SelectListItems, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult getCity(int id)
        {
            City c = db.Cities.FirstOrDefault(x => x.ID == id);
            var cdto = new { ID = c.ID, Name = c.Name };
            return Json(cdto, JsonRequestBehavior.AllowGet);
        }

    }
}