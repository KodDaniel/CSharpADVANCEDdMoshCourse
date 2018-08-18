using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailSerivce: Sending mail to subscriber...");
            Console.ReadLine();
        }

    }
}