using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_pattern
{
    public abstract class Notification
    {
        protected INotification _notification;

        protected Notification(INotification notification)
        {
            _notification = notification;
        }
        public abstract void Notify(string message);
    }
}
