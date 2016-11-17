using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherAPIApp.Models;

namespace WeatherAPIApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Weather2");
        }

        public JsonResult GetWeather()
        {
            WeatherClass myWeather = new WeatherClass();

            return Json(myWeather.GetCurrentWeather(), JsonRequestBehavior.AllowGet);
        }
    }
}