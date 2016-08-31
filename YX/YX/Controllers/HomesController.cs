using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YX.App_Start;
using YX.Models;

namespace YX.Controllers
{
    public class HomesController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        //餐厅美食
        //    Homes/Restaurant
        public ActionResult Restaurant()
        {
            return View();
        }
        //Love wedding()唯爱婚宴
        public ActionResult Love_Wedding()
        {
            return View();
        }
        //Business exclusive会务专属
        public ActionResult Business_exclusive()
        {
            return View();
        }
        //Leisure facilities休闲设施
        public ActionResult Leisure_facilities()
        {
            return View();
        }
    }
}