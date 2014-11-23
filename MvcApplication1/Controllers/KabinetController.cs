using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class KabinetController : Controller
    {
        //
        // GET: /Kabinet/
        private Entities3 db = new Entities3();
      //  [Authorize(Roles = "user")]
        [Authorize(Roles = "admin")] 
        public ActionResult Index()
        {

            return View();
        }
        //[Authorize(Roles = "user")]
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            Kabinets kabinet = new Kabinets();

            return View(kabinet);
        }
        [HttpPost]
        public ActionResult Create(Kabinets kabinet)
        {
          
            try
            {
                if (ModelState.IsValid)
                {
                    db.Kabinets.Add(kabinet);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                    
                }
            }
            catch (Exception ex)
            {
               
                ModelState.AddModelError(String.Empty, ex);
                
            }
            return View(kabinet);
        }
    }
}
