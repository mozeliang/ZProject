using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Z.Core.Service.Main;
using Z.Core.Common;
using UtilityLibrary;

namespace Z.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //var t=new AdministratorsService().Create();



            int[] _ar =  { 1, 2, 3, 10, 2, 5, 6, 54 } ;

            //var r = new System.Random();
            //for (int i = 0; i < 555000; i++)
            //{
            //    _ar[i]=r.Next(9999);
            //}
           
            var strings="sd";

            var startTime = new TimeSpan(DateTime.Now.Ticks);
            var s = ArrayOrderByUtility.IntArrayAsc(_ar);
            //Array.Sort(_ar);
            var endTime = new TimeSpan(DateTime.Now.Ticks);
            var sc = startTime.Subtract(endTime).Duration().TotalMilliseconds;
            ViewBag.sc = sc;
            var startTimes = new TimeSpan(DateTime.Now.Ticks);
            Array.Sort(_ar);
            var endTimes = new TimeSpan(DateTime.Now.Ticks);
            var scs = startTimes.Subtract(endTimes).Duration().TotalMilliseconds;

            var startTimer = new TimeSpan(DateTime.Now.Ticks);
            Array.Reverse(_ar);
            var endTimer = new TimeSpan(DateTime.Now.Ticks);
            var scsr = startTimer.Subtract(endTimer).Duration().TotalMilliseconds;
          
            Func<int, bool> f1 = IsNumberLessThen5;
            bool flag = f1(4);

            return View();
        }

        public int dg(int s)
        {
            var ddd = "";
            var dddd = "";
            if (s > 0)
            {
                s--;
                dg(s);
            }
            return s;
        }

        private static bool IsNumberLessThen5(int number)
        {
            if (number < 5)
                return true;
            return false;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
