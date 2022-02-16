using AdvancedRepository.Business;
using AdvancedRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedRepository.Controllers
{
    public class CustomersController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}