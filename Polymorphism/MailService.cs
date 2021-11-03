using System;

namespace LearningC_.Polymorphism
{
    internal class MailService
    {
        public MailService()
        {
        }

        internal void Send(Mail mail)
        {
            System.Console.WriteLine("Sending email..");
        }
    }
}