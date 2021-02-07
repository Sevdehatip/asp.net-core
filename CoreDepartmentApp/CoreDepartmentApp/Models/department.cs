using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDepartmentApp.Models
{
    public class department
    {
        [Key]
        public int id { get; set; }
        public string departmentName { get; set; }


        public List<employee> employees { get; set; }
    }
}
