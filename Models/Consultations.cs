using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Consultations
    {
        [Key]
        public int ConsultationId { get; set; }
        public string Prescription {  get; set; }
        public string Notes {  get; set; }
    }
}
