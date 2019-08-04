using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace ProjetoModeloDDD.WebApi.Filters.ControllerFilters
{
    public class ClienteFilterAttributes: ActionFilterAttribute
    {

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var clientController = actionContext.ControllerContext.Controller as ClienteController;

            if(clientController!=null)
            {
                clientController.clienteApp = new ClienteAppService();
            }

            base.OnActionExecuting(actionContext);


        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }
    }
}