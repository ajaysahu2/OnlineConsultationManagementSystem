using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId {  get; set; }
        public int PatientId {  get; set; }
        public Patient Patient { get; set; }
        public int DoctorId {  get; set; }
        public Doctor Doctor { get; set; }
        public int SessionId {  get; set; }
        public Session Session { get; set; }
        public int ConsultationId { get; set; }
        public Consultation Consultation { get;set; }
    }
}
