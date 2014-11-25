using MvcApplication1.Models;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MvcApplication1.Controllers
{
    public class UserKabinetController : Controller
    {
       
        //
        // GET: /Kabinet/
        private Entities5 db = new Entities5();
        
        public ActionResult Success()
        {
             return View();
        }
        public ActionResult Details()
        {
            try
            {
                var d = (from kabinet in db.UserKabinet where kabinet.UserId == WebSecurity.CurrentUserId select kabinet).First();
                return View(d);
            }
            catch (Exception p)
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Create()
        {
            UserKabinet kabinet = new UserKabinet();

            return View(kabinet);
        }
        [HttpPost]
        public ActionResult Create(UserKabinet  kabinet)
        {
            
            try
            {
                    
                    if (ModelState.IsValid)
                    {
                        kabinet.UserId = WebSecurity.CurrentUserId;
                        db.UserKabinet.Add(kabinet);
                        db.SaveChanges();
                        return RedirectToAction("Success");
                    
                    }
                }
           
            catch (Exception ex)
            {
               
                ModelState.AddModelError(String.Empty, ex);
                
            }
            return View(kabinet);
        }
        public ActionResult Edit(int id)
        {
            var d = (from kabinet in db.UserKabinet where kabinet.UserId == id select kabinet).First();
            return View(d);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var edit = (from kabinet in db.UserKabinet where kabinet.UserId == id select kabinet).First();
            
            try
            {
                if (ModelState.IsValid)
                {
                    UpdateModel(edit);
                    db.SaveChanges();
                    return RedirectToAction("Details");

                }
            }
            catch
            {
                return View(edit);

            }
            return RedirectToAction("Success");
        }
        
    }
}
