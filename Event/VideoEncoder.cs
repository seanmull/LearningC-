using System;
using System.Threading;

namespace LearningC_.Event
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    internal class VideoEncoder
    {
        public VideoEncoder()
        {
        }
        //1 - Define a delegate
        //2 - Define an events based on that delegate
        //3 - Raise the event

        
        // public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);

        //EventHandler
        //EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;

        internal void Encode(Video video)
        {
            System.Console.WriteLine("Encodeing video...");
            Thread.Sleep(3000); 

            OnVideoEncode(video);
        }

        protected virtual void OnVideoEncode(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
        }
    }
}