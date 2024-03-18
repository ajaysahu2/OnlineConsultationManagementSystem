using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Doctors
    {
        [Key]
        [Display(Name = "Doctor Name")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization {  get; set; }

        //[MinLength(10, ErrorMessage = "Enter a valid Phone Number")]
        public long ContactInfo { get; set; }

    }
}
