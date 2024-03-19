using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Appointments
    {
        [Key]
        public int AppointmentId {  get; set; }
        public int PatientId {  get; set; }
        public Patient Patient { get; set; }
        public int DoctorId {  get; set; }
        public Doctors Doctors { get; set; }
        public int SessionId {  get; set; }
        public Sessions Sessions { get; set; }
        public int ConsultationId { get; set; }
        public Consultations Consultations { get;set; }
    }
}
