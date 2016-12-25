using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Z.Core.Service.Test;

namespace Z.Web.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult MoTest()
        {
           
            weituo we = new weituo(weer);

            var t = new test().name("name") ;
            var t1 = new test1().name("dd");
            var s=we("weer");
            ViewBag.dc = s;
            return View();
        }
        public delegate string weituo(string st);
        public int dui(int a)
        {
            if (1 == a)
                return 1;
            a--;
            var sun = a * dui(a);
            //4*(4)*(3)*1
            return sun;
        }

        public string weiyi(string str)
        {
            return str;
        }

        public string weer(string st)
        { 
            return st;
        }
    }
}
