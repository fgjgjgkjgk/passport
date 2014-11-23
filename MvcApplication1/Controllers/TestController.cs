using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        private KabinetsModelDataContext db = new KabinetsModelDataContext();

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "user")]
        public ActionResult Create()
        {
            Kabinet kabinet = new Kabinet();

            return View(kabinet);
        }
        [HttpPost]
        public ActionResult Create(Kabinet kabinet, UserProfile up)
        {
           
            try
            {
                if (ModelState.IsValid)
                {
                    kabinet.UserId = up.UserId;
                    db.Kabinets.InsertOnSubmit(kabinet);
                    db.SubmitChanges();
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
