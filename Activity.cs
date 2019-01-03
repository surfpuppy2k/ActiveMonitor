using System;

namespace ActiveMonitor
{
    public class Activity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Distance { get; set; }
        public TimeSpan Time { get; set; }
    }
}