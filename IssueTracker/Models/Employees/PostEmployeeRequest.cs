using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IssueTracker.Models.Employees
{
    public class PostEmployeeRequest : IValidatableObject
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="We need a last name!")][StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Range(25000, 500000)]
        [DisplayName("Starting Salary")]
        public decimal StartingSalary { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(FirstName.ToLower() == "darth" && LastName.ToLower() == "vader")
            {
                yield return new ValidationResult("This violates our strict no Sith policy");
            }
        }
    }
}
