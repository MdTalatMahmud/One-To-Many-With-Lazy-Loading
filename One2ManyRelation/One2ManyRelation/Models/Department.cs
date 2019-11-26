using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace One2ManyRelation.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public virtual IList<Student> Students { set; get; }



    }
}