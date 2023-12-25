using System;

namespace OnlineConsultationManagementSystem.Util.Email
{
    public class Message
    {
        public List<string> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Message(List<string> to, string subject, string content)
        {
            To = to;
            Subject = subject;
            Content = content;
        }
    }
}
