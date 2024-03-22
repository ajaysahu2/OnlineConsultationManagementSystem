using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Consultation
    {
        [Key]
        public int ConsultationId { get; set; }
        public string Prescription {  get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
