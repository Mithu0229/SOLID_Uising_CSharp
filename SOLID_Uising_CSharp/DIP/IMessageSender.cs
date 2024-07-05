using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.DIP
{
    //The Dependency Inversion Principle advocates that high-level modules should not
    //depend on low-level modules. Both should depend on abstractions
    public interface IMessageSender
    {
        void SendMessage(string message);
    }

    public class EmailSender: IMessageSender
    {
        public void SendMessage(string message)
        {

        }
    }
    //By using the IMessageSender interface, we've decoupled NotificationService from
    //the concrete implementation of the message sender, allowing for greater flexibility.

    public class NotificationService
    {
        private readonly IMessageSender _sender;
        public NotificationService(IMessageSender sender)
        {
            _sender = sender;
        }

        public void SendNotification(string message)
        {
            _sender.SendMessage(message);
        }
    }
}
