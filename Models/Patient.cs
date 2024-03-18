using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Patient
    {
        [Display(Name = "Patient Name")]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long MobileNumber { get; set; }

        public string Address { get; set; }
    }
}
