using Lvh_lession05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lvh_lession05.Controllers
{
    public class LvhCustomerController : Controller
    {
        // GET: LvhCustomer
        public ActionResult Index()
        {
            return View();
        }
        //action : LvhCustomerDetail
        public ActionResult LvhCustomerDetail()
        {
            // Create a customer object
            var customer = new LvhCustomer()
            {
                CustomerId = 1,
                FirtName = "Lê Văn",
                LastName = "Hoàng",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        //GET: LvhListCutomer
        public ActionResult LvhListCustomer()
        {
            var list = new List<LvhCustomer>()
            {
                new LvhCustomer()
                {
                    CustomerId = 1,
                    FirtName = "Lê Văn",
                    LastName = "Hoàng",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new LvhCustomer()
                {
                    CustomerId=2,
                    FirtName="Thu",
                    LastName="Hương",
                    Address="KT",
                    YearOfBirth=2024
                },
                new LvhCustomer()
                {
                    CustomerId=3,
                    FirtName="Thu",
                    LastName="Hương Aloso",
                    Address="CNTT",
                    YearOfBirth=2024
                },
                new LvhCustomer()
                {
                    CustomerId=4,
                    FirtName="Thu",
                    LastName="Hương 2",
                    Address="KT",
                    YearOfBirth=2024
                },

        };
            //ViewBag.list = list;//Đưa dữ liệu ra view bằng đối tượng viewBag
            return View(list);
        }
    }
}
