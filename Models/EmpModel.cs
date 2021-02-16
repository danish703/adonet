using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adoneta.Models
{
    public class EmpModel
    {
        [Display(Name="Employee Id")]
        public int EmpId { set; get; }

        [Required(ErrorMessage ="First Name is require")]
        public String Name { set; get; }

        [Required(ErrorMessage ="City is required")]
        public String City { set; get; }

        [Required(ErrorMessage ="Address is required")]
        public String Address { set; get; }
    }
}
