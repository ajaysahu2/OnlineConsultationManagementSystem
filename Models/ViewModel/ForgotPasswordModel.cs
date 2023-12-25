using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineConsultationManagementSystem.Models.ViewModel
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
