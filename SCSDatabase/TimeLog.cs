using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class TimeLog
	{
        public Guid ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime CompletionTime { get; set; }
        public TimeSpan Difference { get; set; }

        public TimeLog()
        {
            ID = Guid.NewGuid();
            StartTime = DateTime.Now;
        }
    }
}