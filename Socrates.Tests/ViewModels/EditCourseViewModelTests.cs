using Microsoft.VisualStudio.TestTools.UnitTesting;
using Socrates.Controllers;
using System;
using System.Collections.Specialized;
using System.Web.Mvc;

namespace Socrates.Tests.ViewModels
{
    [TestClass]
    public class EditCourseViewModelTests
    {
        [TestMethod]
        public void ModelBindingVerification()
        {

            var collection = new NameValueCollection();
            collection.Add("Duration", "invalid string");
            FormCollection formCollection = new FormCollection(collection);

            var controller = new CourseController();
            // CourseController.TryUpdateModel
            

        }
    }
}
