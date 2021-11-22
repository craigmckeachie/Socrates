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

        public IEnumerable<Course> GetAll()
        {
            return context.GetAllCourses().ToList();
        }

        public IEnumerable<Course> GetByTitle(string title)
        {
            System.Diagnostics.Debug.WriteLine(title);
            throw new HttpResponseException(HttpStatusCode.InternalServerError);
            //return context.GetAllCourses().Where(c => c.Title.Contains(title)).ToList();
        }


    }
}
