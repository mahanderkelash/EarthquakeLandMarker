using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EarthquakeLandMarker.Controllers
{
    public class EarthquakeMapController : Controller
    {
        // GET: EarthquakeMap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}