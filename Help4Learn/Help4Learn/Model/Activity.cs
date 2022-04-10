using System;
using System.Collections.Generic;
using System.Text;

namespace Help4Learn.Model
{
    public class Activity
    {
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string subject { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Activity(string name, string description, string type, string subject,
            DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.subject = subject;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
