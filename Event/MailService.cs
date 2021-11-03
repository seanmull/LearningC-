using System;

namespace LearningC_.Event
{
        public class MailService
        {
            public void OnVideoEncoded(object sourse, VideoEventArgs e)
            {
               System.Console.WriteLine("MailServce: Sending an email" + e.Video.Title); 
            }
        }
    
}