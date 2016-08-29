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
        // GET: Homes
        TextViewModels _textViewModels;
        public HomesController()
        {
            //_textViewModels = new TextViewModels();
        }

        public ActionResult Index()
        {
            return View();
        }

        [IAuthorize]
        [HttpPost]
        public ActionResult Text()
        {
            _textViewModels = new TextViewModels()
            {
                name = "OK",
                messeges = "成功"
            };
            return Json(_textViewModels);
        }
    }
}