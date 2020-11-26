using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace catalogo.Controllers
{
    public class cineController : Controller
    {
        // GET: cine
        public ActionResult Index()
        {
            return View();
        }
    }
}