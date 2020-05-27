using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCurdApp.Data
{
    public class Employinfo
    {
        [Key]
        public int EmployeeID { get; set; }
        
        [Required (ErrorMessage = "Name is Required")]
        [MinLength(3)]
        public string Name {get;set; }

        public string Gender { get; set; }
       [Required]
       [MinLength(3)]
        public string City { get; set; }
       [EmailAddress]
        public string  Email { get; set; }
    }
}
