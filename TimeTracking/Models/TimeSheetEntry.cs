using System;

namespace TimeTracking.Models
{
    public class TimeSheetEntry
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }


    }
}
