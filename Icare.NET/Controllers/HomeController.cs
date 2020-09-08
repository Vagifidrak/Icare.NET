using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Icare.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Haqqımızda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Əlaqə";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name, string email, string subject, string message)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(message) &&
               !string.IsNullOrEmpty(subject))
            {
                WebMail.SmtpServer = "mail.e-icare.az";
                WebMail.EnableSsl = true;
                WebMail.UserName = "admin@e-icare.az";
                WebMail.Password = "asankira2020";
                WebMail.SmtpPort = 587;
                WebMail.Send("admin@e-icare.az", subject, email + "-" + message);
                TempData["contact"] = "Mesajınız uğurla göndərildi";
            }
            else
            {
                TempData["contact"] = "Xəta baş verdi təkrar yoxlayın";
            }
            return RedirectToAction("Contact");
        }
        public ActionResult FAQ() {

            ViewBag.Message = "FAQ";

            return View();
        }
        public ActionResult Service()
        {

            ViewBag.Message = "Ödəmə";

            return View();
        }
    }
}