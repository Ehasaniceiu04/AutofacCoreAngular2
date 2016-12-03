using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVCApp.Manager;
using Web.CoreApp.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreMVCApp.Controllers
{
 
    public class HomeController : Controller
    {
        private readonly IEngineerManager _engineerManager;
        private readonly EngineerContext _context;
        public HomeController(IEngineerManager engineerManager, EngineerContext context)
        {
            _engineerManager = engineerManager;
            _context = context;
        }
        // GET: /<controller>/
       [HttpGet]
        public IActionResult Index()
        {
           
            ViewBag.Title = "MVC Core with Angular 2";
            // TODO: for testing purposes add is called from here
            //After development of add functionality it will move from here.
            _engineerManager.Add();
            return View();
        }
    }
}
