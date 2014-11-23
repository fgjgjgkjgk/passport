using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class PersonRepository : Controller
    {
        //
        // GET: /PersonRepository/

        public ActionResult Index()
        {
            return View();
        }

    }
}
