using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBills.Controllers
{
    public class BillsController : Controller
    {
        // GET: Bills
        public ActionResult Create()
        {
            return View();
        }
    }
}