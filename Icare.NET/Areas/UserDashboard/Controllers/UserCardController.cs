using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icare.NET.Areas.UserDashboard.Controllers
{
    public class UserCardController : Controller
    {
        // GET: UserDashboard/UserCard
        public ActionResult Index()
        {
            return View();
        }
    }
}