using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailSerivce: Sending mail to subscriber..." + args.Video.Title);
        }

    }
}