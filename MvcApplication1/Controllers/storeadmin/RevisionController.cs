using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers.storeadmin
{
    public class RevisionController : Controller
    {

        private Entities5 db = new Entities5();
        //
        // GET: /Revision/

        public ActionResult Index()
        {
            var queri = (from u in db.gda_passport select u).ToList();
            return View(queri);
        }

        //
        // GET: /Revision/Details/5

        public ActionResult Details(int id)
        {
            var details = (from u in db.gda_passport
                           where u.Id == id
                           select u).First();
            return View(details);
        }

        //
        // GET: /Revision/Create

        public ActionResult Create()
        {
            //gda_passport pasport = new gda_passport();
            Response.Redirect("/Passport/extradition");
            return View();
        }

        //
        // POST: /Revision/Create

        [HttpPost]
        public ActionResult Create(gda_passport pasport)
        {
            try
            {
                if(ModelState.IsValid){
                  
                    return RedirectToAction("Index");
                }

                
            }
            catch
            {
                
            }
            return View();
        }

        //
        // GET: /Revision/Edit/5

        public ActionResult Edit(int id)
        {
            var edit = (from u in db.gda_passport
                           where u.Id == id
                           select u).First();
            return View(edit);
        }

        //
        // POST: /Revision/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var edit = (from u in db.gda_passport
                        where u.Id == id
                        select u).First();

            try
            {
                UpdateModel(edit);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(edit);
            }
        }

        //
        // GET: /Revision/Delete/5

        public ActionResult Delete(int id)
        {
            var del = (from u in db.gda_passport
                        where u.Id == id
                        select u).First();
            return View(del);
        }

        //
        // POST: /Revision/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            var del = (from u in db.gda_passport
                       where u.Id == id
                       select u).First();
            try
            {
                db.gda_passport.Remove(del);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                
            }
            
            return View();
        }
    }
}
