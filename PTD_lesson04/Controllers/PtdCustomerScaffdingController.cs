using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTD_lesson04.Models;  // Ensure this namespace matches where PtdCustomer is defined

namespace PTD_lesson04.Controllers
{
    public class PtdCustomerScaffoldingController : Controller
    {
        // Mock data
        private List<PtdCustomer> listCustomer = new List<PtdCustomer>()
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
                CustomerId = 2,
                FirstName = "Tran Anh",
                LastName = "Sang",
                Address = "K22CNT3",
                YearOfBirth = 2004
            },
            new PtdCustomer()
            {
                CustomerId = 3,
                FirstName = "Tran Anh",
                LastName = "Sang",
                Address = "K22CNT3",
                YearOfBirth = 2004
            },
            new PtdCustomer()
            {
                CustomerId = 4,
                FirstName = "Tran Anh",
                LastName = "Sang",
                Address = "K22CNT3",
                YearOfBirth = 2004
            }
        };

        // GET: PtdCustomerScaffolding
        //listcustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult PtdCreate()
        {
            var model = new PtdCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult PtdCreate(PtdCustomer model)
        {
            //them moi doi tuong khach hang vao ds du lieu
            listCustomer.Add(model);
            //return View(model);
            // chuyen ve trang danh sach
            return RedirectToAction("Index");
        }
        public ActionResult PtdEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View();
        }
    }
}