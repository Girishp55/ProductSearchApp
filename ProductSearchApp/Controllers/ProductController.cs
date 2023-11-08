using ProductSearchApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductSearchApp.Controllers
{
    public class ProductController : Controller
    {
       girishEntities db = new girishEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.tblProducts.ToList());
        }

        [HttpPost]
        public ActionResult Index(string searching)
        {
            return View(db.searchproduct(searching).ToList());
        }

    }
}