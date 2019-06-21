using MVCHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers.Controllers
{
    public class BaseController : Controller
    {
        NorthwindEntities db;
        public BaseController()
        {
            db = new NorthwindEntities();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}