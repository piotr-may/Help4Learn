using System;
using System.Collections.Generic;
using System.Text;

namespace Help4Learn.Model
{
    public class Task
    {
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string subject { get; set; }
        public int priority { get; set; } //0 - less important 10 - most
        public DateTime date { get; set; }

        public Task(string name, string description, string type, string subject,
            int priority, DateTime date)
        {
            this.name = name;
            this.description = description;
            this.type = type;
            this.subject = subject;
            this.priority = priority;
            this.date = date;
        }

        public Task( Task copy)
        {
            this.name = copy.name;
            this.description = copy.description;
            this.type = copy.type;
            this.subject = copy.subject;
            this.priority = copy.priority;
            this.date = copy.date;
        }
    }
}
