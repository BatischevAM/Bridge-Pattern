using Bridge_pattern;

class Program
{
    static void Main(string[] args)
    {
        // Создаем уведомления
        INotification emailNotification = new EmailNotification();
        INotification smsNotification = new SmsNotification();

        Notification textEmail = new TextNotification(emailNotification);
        Notification htmlEmail = new HtmlNotification(emailNotification);
        Notification textSms = new TextNotification(smsNotification);
        Notification htmlSms = new HtmlNotification(smsNotification);

        // Отправляем уведомления
        textEmail.Notify("Это текстовое сообщение по Email.");
        htmlEmail.Notify("Это HTML сообщение по Email.");
        textSms.Notify("Это текстовое сообщение по SMS.");
        htmlSms.Notify("Это HTML сообщение по SMS.");
    }
}
