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

            int[] _ar = { 10, 2, 3, 4, 0, 11 };
            Array.Sort(_ar);
            for (int i = 0; i < _ar.Length; i++)
            {

                for (int j = _ar.Length - 1; j >= 0; j--)
                {
                    var currentValue = _ar[0];
                    var max = _ar[j];
                    if (max > currentValue)
                    {
                        var min = _ar[j - 1];
                        _ar[j-1] = currentValue;
                        _ar[0] = min;
                    }
                }
            }


            XmlUtility xm = new XmlUtility();
            xm.test();

            Func<int, bool> f1 = IsNumberLessThen5;
            bool flag = f1(4);

            return View();
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
