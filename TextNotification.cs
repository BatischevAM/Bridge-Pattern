using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public class TextNotification : Notification
    {
        public TextNotification(INotification notification): base(notification) { }
        public override void Notify(string message)
        {
            _notification.Send(message);
        }
    }
}
