using System;
using System.Threading;

namespace LearningC_.StopWatch.cs
{
    public class StopWatch
    {
        private DateTime startTime = new DateTime();
        private TimeSpan localTimeDifference = new TimeSpan();
        private double totalTimeInSeconds { get; set; } = 0;
        private bool isWatchStopped = true;

        public void Start(){
           if(!isWatchStopped){
               throw new InvalidOperationException("Cannot start twice in a row");
           }
               startTime = DateTime.Now;
               isWatchStopped = false;
           
        }

        public void Stop(){
            localTimeDifference = DateTime.Now - startTime;
            totalTimeInSeconds += localTimeDifference.TotalSeconds;
            isWatchStopped = true;
        }

        //  public static void Main(string[] args){
        //      var stopWatch = new StopWatch();
        //      stopWatch.Start();
        //      Thread.Sleep(2000);
        //      stopWatch.Stop();
        //      stopWatch.Start();
        //      Thread.Sleep(2000);
        //      stopWatch.Stop();
        //      Console.WriteLine(stopWatch.totalTimeInSeconds);
        //  }
    }
}