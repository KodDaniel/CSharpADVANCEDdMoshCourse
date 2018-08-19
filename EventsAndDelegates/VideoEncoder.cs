using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // Custom Delegate

        public event EventHandler<VideoEventArgs> VideoEncoded; //Event and Delegate in same


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            //Encoding är klart i och med Console.Writeline så nedan anropar vi Event Handler för att meddela våra subscribers om detta.

            OnVideoEncoded(video); 
        }

        protected virtual void OnVideoEncoded(Video video) 
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this,new VideoEventArgs(){Video = video});
            }
        }


    }
}
