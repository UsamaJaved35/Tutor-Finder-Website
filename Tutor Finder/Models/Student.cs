using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_Finder.Models
{
    public class Student
    {
        //Model Validations
        [Required (ErrorMessage ="Enter First Name :")]
        [StringLength(10)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter last Name :")]
        [StringLength(10)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Password:")]
        [StringLength(10)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter Gender:")]
        [StringLength(10)]
        public string Gender { get; set; } = "Unspecified";
        [Required(ErrorMessage = "Enter Eduction:")]
        [StringLength(50)]
        public string Education { get; set; }
        [Required(ErrorMessage = "Enter Address:")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Country:")]
        [StringLength(50)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Enter PhoneCode:")]
        [StringLength(10)]
        public string PhoneCode { get; set; }
        [Required(ErrorMessage = "Enter PhoneNumber:")]
        [StringLength(14)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter Email:")]
        [StringLength(50)]
        public string Email { get; set; }
    }
}