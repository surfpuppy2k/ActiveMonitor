using System;
using System.Collections.Generic;

namespace ActiveMonitor
{
    public class ActivityTracking
    {
        public int DurationDays { get; set; }
        public int Start { get; set; }
        public int Goal { get; set; }
        public int StretchGoal { get; set; }
        public List<Activity> Activities { get; set; }
    }
}