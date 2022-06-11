using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustInGermany()
        {
            List<Customer> customers = (from cust in db.Customers
                                        where cust.Country == "Germany"
                                        select cust).ToList();
            return View(customers);
        }
        public ActionResult GetCustomersById()
        {
            List<Customer> customers = (from cust in db.Customers
                                        join orders in db.Orders on cust.CustomerID equals orders.CustomerID
                                        where orders.OrderID == 10248
                                        select cust).ToList();
            return View(customers);
        }
    }
}