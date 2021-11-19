using Microsoft.VisualStudio.TestTools.UnitTesting;
using Socrates.DataAccess;
using System;
using System.Configuration;
using System.Linq;

namespace Socrates.Tests.DataAccess
{
    [TestClass]
    public class SocratesContextTests
    {
        [TestMethod]
        public void GetAllDepartments()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            var context = SocratesContextFactory.GetContext(connStr);
            var departments = context.GetAllDepartments().ToList();
            Assert.IsNotNull(departments);
        }
    }
}
