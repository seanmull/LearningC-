using System;

namespace LearningC_.Event
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("Message : sending a text message" + e.Video.Title);
        }
    }
}