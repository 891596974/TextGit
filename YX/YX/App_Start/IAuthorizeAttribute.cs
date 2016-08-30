using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using YX.Logger.DLL;

namespace YX.App_Start
{
    public class IAuthorizeAttribute :AuthorizationFilterAttribute
    {
        ResultErrorViewModels _resultError;
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //表单验证,使用表单身份验证用户身份验证
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                return;
            }
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader != null)
            {
                string token = actionContext.Request.Headers.Authorization.Parameter;
                //验证成功
                if (string.Equals(token,"abc123"))
                {
                    return;
                }
            }
            HandleUnauthorizedRequest(actionContext);
        }
        
        #region 未通过验证;      
        private void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {//验证失败返回404
            _resultError = new ResultErrorViewModels() { reslut = "UnAuthorization,Messages ERROR:404", message = "UnAuthorization:无效的验证或验证失败" };
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, _resultError);
        }
        #endregion
    }
}