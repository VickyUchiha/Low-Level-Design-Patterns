using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.DPatterns
{
    public class Factory
    {
        public static void NotMain(string[] args)
        {
            var notification = NotificaitonFactory.CreateNotification("email");
            notification.send("Hello");
            notification = NotificaitonFactory.CreateNotification("sms");
            notification.send("Hello");
        }
    }
    public interface INotification
    {
        void send(string message);
    }

    public class EmailNotification : INotification
    {
        public void send(string message)
        {
            Console.WriteLine($"Sending email : {message}");
        }
    }

    public class SMSNotification : INotification
    {
        public void send(string message)
        {
            Console.WriteLine($"Sending SMS : {message}");
        }
    }

    public class NotificaitonFactory
    {
        public static INotification CreateNotification(string message)
        {
            return message.ToLower() switch { "email" => new EmailNotification(),
            "sms" => new SMSNotification(),
            _ => throw new ArgumentException("Inavalid Notification Type")};
        }
    }
}
