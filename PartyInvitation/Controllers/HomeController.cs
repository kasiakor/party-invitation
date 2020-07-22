using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvitation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Hello = hour < 12 ? "Good morning" : "Good evening";
            return View();
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}