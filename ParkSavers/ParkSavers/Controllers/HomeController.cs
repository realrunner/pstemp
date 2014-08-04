using ParkSavers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ParkSavers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public String TestMe()
        {
            var ctx = new ParkSaversContext();
            var builder = new StringBuilder();
            foreach(Product prod in ctx.Products){
                builder.Append(prod.Description).Append("\n");
            }
            
            return "<h1>Products</h1><pre>" + builder + "</pre>";
        }
    }
}