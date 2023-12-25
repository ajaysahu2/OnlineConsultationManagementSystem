namespace OnlineConsultationManagementSystem.Util.Email
{
    public interface IEmailService
    {
        Task SendAsync(Message message);
    }
}
