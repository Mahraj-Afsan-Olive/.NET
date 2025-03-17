using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmission.Models
{
    public class Student
    {
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "Please provide correct Id")]
        public string Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z._\s]*$", ErrorMessage ="Please provide right format for name.")]
        public string Name { get; set; }
        [Required]
        [IdMatchesEmail(ErrorMessage = "Email must match the Id format (e.g., Id@student.aiub.edu).")]
        public string Email { get; set; }
        [Required]
        public string Dob { get; set; }

    }
    
}