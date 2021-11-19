using Socrates.DataAccess;
using Socrates.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Socrates.API
{
    public class CourseController : ApiController
    {
        private ISocratesContext context;

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            context = SocratesContextFactory.GetContext(connStr, false);
        }

        public IEnumerable<Course> Get()
        {
            return context.GetAllCourses().ToList();
        }
    }
}
