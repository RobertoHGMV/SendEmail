namespace SendEmail.Services
{
    public class EmailParameters
    {
        public string Host { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public string UserNameFrom { get; set; }
        public string Password { get; set; }
    }
}
