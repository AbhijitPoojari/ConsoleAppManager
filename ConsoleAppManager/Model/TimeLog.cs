using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppManager.Model
{
    class TimeLog
    {
        public int TimeLogID { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationTitle { get; set; }
        public DateTime TimestampStarted { get; set; }
        public DateTime TimestampEnded { get; set; }
    
    }
}
