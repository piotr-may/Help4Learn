using System;
using System.Collections.Generic;
using System.Text;

namespace Help4Learn.Model
{
    public class Callendar
    {
        public int currentWeek { get; set; }
        public int currentDay { get; set; }
        public int currentMonth { get; set; }
        public int currentYear { get; set; }

        public Callendar()
        {
            DateTime date = DateTime.Now;
            currentDay = date.Day;
            currentMonth = date.Month;
            currentYear = date.Year;
            currentWeek = countWeek();
        }

        private int countWeek()
        {
            return 5;
        }
    }
}
