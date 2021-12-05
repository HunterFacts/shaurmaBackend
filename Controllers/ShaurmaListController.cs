using BackendCoffee.Data;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendCoffee.Controllers
{
    public class ShaurmaListController : Controller
    {
        private ShaurmaContext db = new ShaurmaContext();
        // GET: ShaurmaList
        public JsonResult Index()
        {
            return Json(new { Data = db.Shaurmas.ToList() }, JsonRequestBehavior.AllowGet );
        }
    }
}