using System;
using System.ComponentModel.DataAnnotations;

namespace Invelop.Task.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string Surname { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(15)]
        [MinLength(6)]
        [RegularExpression("^([0-9]{6,15} *)$", ErrorMessage = "Phone Number must be numeric and between 6 and 15 symbols long.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "IBAN")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "IBAN must contain only netters and numbers.")]
        public string Iban { get; set; }
    }
}