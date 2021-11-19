using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Socrates.Filters
{
    public class TimestampAttribute : ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(DateTime.Now.ToString("HH:mm:ss:ffff") + " - ");
            
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(DateTime.Now.ToString("HH:mm:ss:ffff"));
        }
    }
}