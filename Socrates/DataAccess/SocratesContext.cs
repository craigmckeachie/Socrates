using Socrates.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Socrates.DataAccess
{
    public class SocratesContext : DbContext, ISocratesContext
    {
        public SocratesContext(string connStr, bool useProxies = true)
            : base(connStr) 
        {
            Configuration.ProxyCreationEnabled = useProxies;
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }

        public IQueryable<Course> GetAllCourses()
        {
            return Courses;
        }

        public IQueryable<Department> GetAllDepartments()
        {
            return Departments;
        }

        public IQueryable<Instructor> GetAllInstructors()
        {
            return Instructors;
        }

        public void MarkAsModified(object obj)
        {
            Entry(obj).State = EntityState.Modified;
        }

        public void MarkAsAdded(object obj)
        {
            Entry(obj).State = EntityState.Added;


        }

        public void MarkDepartmentAsAdded(Department department)
        {
 
            Departments.Add(department);

        }

        public void MarkAsDeleted(object obj)
        {
            Entry(obj).State = EntityState.Deleted;
        }

        void ISocratesContext.SaveChanges()
        {
            SaveChanges();
        }

       

    
    }
}