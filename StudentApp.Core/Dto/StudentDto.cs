using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Core.Dto
{
    public class StudentDto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your first name"), MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name"), MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number"), MaxLength(50)]

        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address"), MaxLength(50)]
        public string Address { get; set; }
    }
}
