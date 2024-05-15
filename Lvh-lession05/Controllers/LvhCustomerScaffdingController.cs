using Lvh_lession05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lvh_lession05.Controllers
{
    public class LvhCustomerScaffdingController : Controller
    {
        // Mock data
        private static List<LvhCustomer> listCustomer = new List<LvhCustomer>
        {
            new LvhCustomer
            {
                CustomerId = 1,
                FirtName = "Lê Văn",
                LastName = "Hoàng",
                Address = "K22CNT3",
                YearOfBirth = 2004
            },
            new LvhCustomer
            {
                CustomerId = 2,
                FirtName = "Thu",
                LastName = "Hương",
                Address = "KT",
                YearOfBirth = 2024
            },
            new LvhCustomer
            {
                CustomerId = 3,
                FirtName = "Thu",
                LastName = "Hương Aloso",
                Address = "CNTT",
                YearOfBirth = 2024
            },
            new LvhCustomer
            {
                CustomerId = 4,
                FirtName = "Thu",
                LastName = "Hương 2",
                Address = "KT",
                YearOfBirth = 2024
            }
        };

        // GET: LvhCustomerScaffding
        // List customer
        public ActionResult Index()
        {
            return View(listCustomer); // Passing the list of customers to the view
        }

        [HttpGet]
        public ActionResult LvhCreate()
        {
            var model = new LvhCustomer();
            return View(model);
        }

        [HttpPost]
        public ActionResult LvhCreate(LvhCustomer model)
        {
            // Add the new customer object to the data list
            listCustomer.Add(model);
            // Redirect to the list page
            return RedirectToAction("Index");
        }
        public ActionResult LvhEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}
