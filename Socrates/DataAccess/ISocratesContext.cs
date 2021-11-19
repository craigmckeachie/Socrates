using Socrates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Socrates.DataAccess
{
    public interface ISocratesContext
    {
        IQueryable<Course> GetAllCourses();
        IQueryable<Department> GetAllDepartments();
        IQueryable<Instructor> GetAllInstructors();

        void MarkAsModified(object obj);
        void MarkAsAdded(object obj);
        void MarkAsDeleted(object obj);

        void SaveChanges();
        void Dispose();
    }
}