using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace One2ManyRelation.Models
{
    public class ProjectDBContext:DbContext
    {
        public ProjectDBContext() : base("OneToMany")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}