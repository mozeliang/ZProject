using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Z.Web.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult MoTest()
        {
            var s = dui(5);
            ViewBag.dc = s;
            return View();
        }

        public int dui(int a)
        {
            if (1 == a)
                return 1;
            a--;
            var sun = a * dui(a);
            //4*(4)*(3)*1
            return sun;
        }
    }
}
