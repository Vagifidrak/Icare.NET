using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icare.NET.Areas.UserDashboard.Controllers
{
    public class UserPaymentController : Controller
    {
        // GET: UserDashboard/UserPayment/History
        public ActionResult Index()
        {
            return View();
        }
        // GET: UserDashboard/UserRentalPayment/History
        public ActionResult IndexRent()
        {
            return View();
        }
    }
}