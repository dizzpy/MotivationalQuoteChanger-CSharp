using System;
using System.Timers;

namespace MotivationalQuoteChanger.classes
{
    public static class TimerManager
    {
        public static void InitializeTimer(System.Timers.Timer timer, double interval, ElapsedEventHandler elapsedEventHandler)
        {
            timer = new System.Timers.Timer();
            timer.Interval = interval;
            timer.Elapsed += elapsedEventHandler;
            timer.Start();
        }
    }
}