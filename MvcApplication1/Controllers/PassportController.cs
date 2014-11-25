using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using WebMatrix.WebData;
using MvcApplication1.Models.MyModel;
using MvcApplication1.Validation;

namespace MvcApplication1.Controllers
{

    public class PassportController : Controller
    {
        private GetUserInf usinf = new GetUserInf();
        private Validations Vdana = new Validations();
        private List<String> ListVdata = new List<String>();
        private int UserId = WebSecurity.CurrentUserId;

        // GET: /Passport/

      //  [Authorize(Roles = "user")] 
        public ActionResult Index()
        {
            return View();
        }

     //   [Authorize(Roles = "user")]
        public ActionResult extradition()
        {
            ViewBag.UserInf = usinf.Getuser();
            ListVdata.Add("");

            ViewBag.we = ListVdata;
            ViewBag.mm = ListVdata;          
            
            return View("extradition");
        }
 
        [HttpPost]
        [Authorize(Roles = "user")]
        public ActionResult extraditionS(String surname, String name, String patronymic,
                                        String born, String kingdom, String gender, String marital_status, String family_surname,
                                        String family_name, String family_patronymic, String family_who_registered, String family_when_registered,
                                        String mom_surname, String mom_name, String mom_patronymic, String father_surname, String father_name,
                                        String father_patronymic, String residence_city, String residence_house, String residence_apartment,
                                        String foreign_citizenship, String foreign_citizenship_where, String foreign_citizenship_now,
                                        String reason_for_issuing, String date_of_filling)
        {
            String[] ArrayNotEmpty = { surname, name, patronymic, born, kingdom, gender, marital_status, mom_surname, mom_name, mom_patronymic,
                                     father_surname, father_name, father_patronymic, residence_city, residence_house, residence_apartment, foreign_citizenship};
            String[] ArrayLengt = { surname, name, patronymic, born, kingdom, mom_surname, mom_name, mom_patronymic,
                                     father_surname, father_name, father_patronymic, residence_city, residence_house};

            ViewBag.UserInf = usinf.Getuser();

            if (Vdana.VNotempty(ArrayNotEmpty).IndexOf("Поле") != -1)
            {
                ViewBag.we = Vdana.VNotempty(ArrayNotEmpty);
                ViewBag.mm = ListVdata;
            }
            else
            {
                if (Vdana.VLengt(ArrayLengt, 3, 20).IndexOf("Поле") != -1)
                {
                    ViewBag.mm = Vdana.VLengt(ArrayLengt, 3, 20);
                    ViewBag.we = ListVdata;
                }
                else {
                    ViewBag.we = ListVdata;
                    ViewBag.mm = ListVdata;

                    usinf.SQLInsert("gda_passport",
                        "id_user, surname, name, patronymic, born, kingdom, gender, marital_status, family_surname, family_name, family_patronymic, family_who_registered, family_when_registered, mom_surname, mom_name, mom_patronymic, father_surname, father_name, father_patronymic, residence_city, residence_house, residence_apartment, foreign_citizenship, foreign_citizenship_where, foreign_citizenship_now, reason_for_issuing, date_of_filling",
                        " " + UserId + ", '" + surname + "','" + name + "','" + patronymic + "','" + born + "','" + kingdom + "','" + gender + "','" + marital_status + "','" + family_surname + "','" + family_name + "','" + family_patronymic + "','" + family_who_registered + "','" + family_when_registered + "','" + mom_surname + "','" + mom_name + "','" + mom_patronymic + "','" + father_surname + "','" + father_name + "','" + father_patronymic + "','" + residence_city + "','" + residence_house + "','" + residence_apartment + "','" + foreign_citizenship + "','" + foreign_citizenship_where + "','" + foreign_citizenship_now + "','" + reason_for_issuing + "','" + date_of_filling + "' ");
                } 
            }

            return View("extradition");
        }

    }
}
