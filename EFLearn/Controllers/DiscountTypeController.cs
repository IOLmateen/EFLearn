using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFLearn.Controllers
{
    public class DiscountTypeController : Controller
    {

        // GET: DiscountType
        public ActionResult Index()
        {
            var _context = new TestDBContext();            
            var res = _context.M_DiscountType.ToList();

            return View(res);
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult Hello1()
        {
            return View();
        }

        public ActionResult Hello1()
        {
            return View();
        }

    }
}