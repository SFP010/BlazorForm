using System;
using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.ValidationAttribute;

namespace BlazorForm.Data
{
    public class Patient
    {
        public int ID { get; set; }

        [Required, StringLength(60, MinimumLength = 3), RegularExpression(@"^[a-zA-Z]+$")]
        public string FirstName { get; set; }

        [Required, StringLength(60, MinimumLength = 3), RegularExpression(@"^[a-zA-Z]+$")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Day of birth is required.")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }
        
        [Required (ErrorMessage = "E-mail is required."), EmailAddress]
        public string Email { get; set; }
        
        [Required (ErrorMessage = "Phone number is required."), RegularExpression(@"^[\d]{9}$")]
        public string PhoneNumber { get; set; }
        
        public bool Identification { get; set; }

       
    }
}