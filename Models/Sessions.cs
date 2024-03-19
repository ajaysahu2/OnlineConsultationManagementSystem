using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Sessions
    {
        [Key]
        public int SessionId { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Session Date Time")]
        public DateOnly Session_Date_Time { get; set; }
        public string VideoLink {  get; set; }
    }
}
