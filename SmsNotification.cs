using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class SmsNotification: INotification
    {
        public void Send(string message)
        {
            // Логика отправки Email
            Console.WriteLine($"Отправка SMS: {message}");
        }
    }
}
