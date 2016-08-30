using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using YX.App_Start;
using YX.Models;

namespace YX.Controllers
{
    public class TextApiController : ApiController
    {
        TextViewModels _textViewModels=new TextViewModels();

        [HttpPost]
        //     api/TextApi/Text
        [IAuthorize]
        public TextViewModels Text([FromBody]TextViewModels modles)
        {
            if (modles != null)
            {
                _textViewModels = new TextViewModels()
                {
                    name =modles.name,
                    messeges = "成功"
                };
            }
            return _textViewModels;
        }
    }
}