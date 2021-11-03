using System;
using System.Collections.Generic;

namespace LearningC_.ExceptionHandling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
        :base(message,innerException)
        {
            
        }
    }
    public class YouTubeApi

    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                 //Access YouTube web service
                 //Read the data
                 //Create a list of Video object
                 throw new Exception("Ooops some low level exception");
            }
            catch (System.Exception ex)
            {
               //Log 
                throw new YouTubeException("Could not fetch the video from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}