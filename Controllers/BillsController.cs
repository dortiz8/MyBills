using MyBills.Models;
using MyBills.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBills.Controllers
{
    public class BillsController : Controller
    {
        private ApplicationDbContext _context; 
        public BillsController()
        {
            _context = new ApplicationDbContext(); 
        }
        // GET: Bills
        public ActionResult Create()
        {
            var viewModel = new BillFormViewModel
            {
                CostTypes = _context.CostTypes.ToList(), 
                Categories = _context.Categories.ToList()
            }; 

            return View("Create", viewModel);
        }
    }
}