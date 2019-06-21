using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers.Controllers
{
    public class AntiForgeyTokenController : Controller
    {
        // GET: AntiForgeyToken
        public ActionResult Index()
        {
            return View();
        }
    }
}