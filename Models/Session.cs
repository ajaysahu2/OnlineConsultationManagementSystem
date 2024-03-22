using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        
        [DataType(DataType.DateTime)]
        [Display(Name = "Session Date Time")]
        public DateTime Session_Date_Time { get; set; }
        
        public string VideoLink {  get; set; }
    }
}
