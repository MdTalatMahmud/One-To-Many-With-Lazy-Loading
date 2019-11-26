using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace One2ManyRelation.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }

        //[ForeignKey("Id")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}