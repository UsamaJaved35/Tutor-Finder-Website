using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_Finder.Models
{
    public class Tutor
    {
        //MODEL VALIDATIONS
        [Required(ErrorMessage = "Enter FirstName:")]
        [StringLength(10)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter LastName:")]
        [StringLength(10)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Enter Password:")]
        [StringLength(10)]
        public string Password  { get; set; }
        [Required(ErrorMessage = "Enter gender:")]
        [StringLength(10)]
        public string Gender { get; set; } = "Unspecified";
        [Required(ErrorMessage = "Enter Qualification:")]
        [StringLength(50)]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Enter Experience:")]
        [StringLength(10)]
        public string Experience { get; set; }
        [Required(ErrorMessage = "Enter Subjects:")]
        [StringLength(50)]
        public string Subjects { get; set; }
        [Required(ErrorMessage = "Enter Street Address:")]
        [StringLength(50)]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "Enter Zip Code:")]
        [StringLength(10)]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Enter Country:")]
        [StringLength(10)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Enter Phone code:")]
        [StringLength(14)]
        public string PhoneCode { get; set; }
        [Required(ErrorMessage = "Enter Phone Number:")]
        [StringLength(14)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Enter Password:")]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
