using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId {  get; set; }

        [Required(ErrorMessage ="please enter patient ID")]
        [Display(Name = "Patient")]
        public int PatientId {  get; set; }
        
        public Patient Patient { get; set; }
        
        [Required]
        [Display(Name = "Doctor")]
        public int DoctorId {  get; set; }
        
        public Doctor Doctor { get; set; }
        
        [Required]
        [Display(Name = "Available Session")]
        public int SessionId {  get; set; }
        
        public Session Session { get; set; }
        
        [Required]
        [Display(Name = "Consultation")]
        public int ConsultationId { get; set; }
        
        public Consultation Consultation { get;set; }
    }
}
