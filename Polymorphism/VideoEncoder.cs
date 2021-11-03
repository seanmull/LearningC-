using System;
using System.Collections.Generic;

namespace LearningC_.Polymorphism
{
    public class SmsNoticationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS..");
        }
    }
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending mail..");    
        }
    }
    public interface INotificationChannel
    {
        void Send(Message message);
    } 
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        internal void Encode(Video video)
        {
            foreach(var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificaitonChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
            
        }

    }
}