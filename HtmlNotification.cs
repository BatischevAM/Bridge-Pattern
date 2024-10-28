using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class HtmlNotification : Notification
    {
        public HtmlNotification(INotification notification) : base(notification) { }
        public override void Notify(string message)
        {
            string htmlMessage = $"<html><body>{message}</body></html>";
            _notification.Send(htmlMessage);
        }
    }
}
