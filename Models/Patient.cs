using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Patient
    {
        [Key]
        [Display(Name = "Patient Name")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        [MinLength(10, ErrorMessage = "Enter a valid Phone Number")]
        public long ContactInfo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateOnly DateOfBirth { get; set; }

        public string Address { get; set; }
    }
}
