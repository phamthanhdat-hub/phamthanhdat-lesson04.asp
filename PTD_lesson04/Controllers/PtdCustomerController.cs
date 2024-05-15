using PTD_lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTD_lesson04.Controllers
{
    public class PtdCustomerController : Controller
    {
        // GET: PtdCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action: PtdCustomerDetail
        public ActionResult PtdCustomerDetail()
        {
            // tao doi tuong du lieu
            var customer = new PtdCustomer()
            {
                CustomerId = 1,
                FirstName = "Pham Thanh",
                LastName = "Dat",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;

            return View();
        }
        //GET: PtdListCustomer
        public ActionResult PtdListCustomer()
        {
            var list = new List<PtdCustomer>()
            {
               new PtdCustomer()
               {
                   CustomerId = 1,
                FirstName = "Pham Thanh",
                LastName = "Dat",
                Address = "K22CNT3",
                YearOfBirth = 2004
               },
               new PtdCustomer()
               {
                   CustomerId=2,
                   FirstName=" Tran Anh",
                   LastName="Sang",
                   Address = "K22CNT3",
                YearOfBirth = 2004
               },
               new PtdCustomer()
               {
                   CustomerId=3,
                   FirstName=" Tran Anh",
                   LastName="Sang",
                   Address = "K22CNT3",
                YearOfBirth = 2004
               },
               new PtdCustomer()
               {
                   CustomerId=4,
                   FirstName=" Tran Anh",
                   LastName="Sang",
                   Address = "K22CNT3",
                YearOfBirth = 2004
               },
            };
            ViewBag.list = list; // Dua ra view bang doi tuong viewBag

            return View();
        }
    }
}