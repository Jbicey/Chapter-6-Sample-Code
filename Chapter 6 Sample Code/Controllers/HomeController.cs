using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter_6_Sample_Code.Models;
using Ninject;

namespace Chapter_6_Sample_Code.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products =
        {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M },
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.955M },
            new Product {Name = "Soccer Ball", Category = "Soccer", Price = 19.50M },
            new Product {Name = "Corner Flag", Category = "Soccer", Price = 34.95M },
        };
        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();


            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}