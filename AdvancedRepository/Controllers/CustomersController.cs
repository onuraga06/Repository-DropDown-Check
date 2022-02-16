using AdvancedRepository.Business;
using AdvancedRepository.Models;
using AdvancedRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvancedRepository.Controllers
{
    public class CustomersController : Controller
    {
    
        MyRepository.CustomersRepository my = new MyRepository.CustomersRepository();
        CustomerModel cm = new CustomerModel();
        public ActionResult Index()
        {
            cm.clist = my.GetList();
            return View(cm);
        }
        public ActionResult Detay(string id)
        {
            cm.customers = my.Bul(id);
            return View(cm);
        }
        public ActionResult Sil(string id)
        {
            Customers cm = my.Bul(id);
            my.Delete(cm);
            my.Save();
            return RedirectToAction("Index");
        }
        
        public ActionResult Guncel(string id)
        {
            cm.customers = my.Bul(id);
            
            return View(cm);
        }
        [HttpPost]
        public ActionResult Guncel(string id,CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                Customers sec = my.Bul(id);
                sec.CompanyName = model.customers.CompanyName;
                sec.ContactName = model.customers.ContactName;
                sec.City = model.customers.City;
                my.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}