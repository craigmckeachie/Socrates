using Socrates.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Socrates.Controllers
{
    public class SocratesController : Controller
    {
        protected ISocratesContext context;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            context = SocratesContextFactory.GetContext(connStr);
        }
    }
}