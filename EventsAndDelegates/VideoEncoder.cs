using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args); // Delegate

        public event VideoEncodedEventHandler VideoEncoded; //Event

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            //Encoding är klart i och med Console.Writeline så nedan anropar vi Event Handler för att meddela våra subscribers om detta.

            OnVideoEncoded(); // Anropar EventHandler
        }

        protected virtual void OnVideoEncoded() // EventHandler 
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this,EventArgs.Empty);
            }
        }


    }
}
