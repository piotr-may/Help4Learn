using System;
using System.Collections.Generic;
using System.Text;

namespace Help4Learn.Model
{
    public class Callendar
    {
        public int currentWeek { get; set; }
        private int currentDay_calc;
        public int currentDay
        {
            get { return currentDay_calc; }
            set
            {
                currentDay_calc = calculateDay(value);
            }
        }
        public int currentMonth { get; set; }
        public int currentYear { get; set; }

        public Callendar()
        {
            DateTime date = new DateTime(2022, 4, 10, 12, 10, 0);
            currentDay = date.Day;
            currentMonth = date.Month;
            currentYear = date.Year;
            currentWeek = 30;
        }

        private int calculateDay(int newValue)
        {
            int newDay = currentDay;
            if (newValue < newDay)
            {
                currentWeek--;
            }
            else
            {
                currentWeek++;
            }

            if (newValue < 0)
            {
                newDay = 30 + newValue;
                currentMonth--;
            }
            else if (newValue == 0)
            {
                newDay = 30;
            }
            else if (newDay > 23 && newValue > newDay)
            {
                newDay = newValue - 30;
                currentMonth++;
            }
            else
            {
                newDay = newValue;
            }

            return newDay;
        }

    }
}
