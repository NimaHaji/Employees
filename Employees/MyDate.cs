using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Employees
{
    public class MyDate
    {
        private int day, month, year;
        public PersianCalendar calender = new PersianCalendar();
        public int Day
        {
            get { return day; }
            set { day = (value >= 1 && value <= 31) ? value : 1; }
        }
        public int Month
        {
            get { return month; }
            set { month = (value >= 1 && value <= 12) ? value : 1; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }

        }
        public MyDate()
        {
            day = 24; month = 2; year = 1403;
        }
       
        public MyDate(int day, int m, int y)
        {
            Day = day; Month = m; Year = y;
        }
        public void AddDate(int d, int m, int y)
        {
            day += d;
            month += m;
            year += y;
        }
        public void Age()
        {
            int YearNow = calender.GetYear(DateTime.Now);
            year = YearNow - year;
            int monthNow = calender.GetMonth(DateTime.Now);
            month = monthNow - Month;
            int daynow = calender.GetDayOfMonth(DateTime.Now);
            day = daynow - day;
            if (day < 0)
            {
                month--;
                day += calender.GetDaysInMonth(YearNow, monthNow);
            }

            if (month < 0)
            {
                year--;
                month += 12;
            }
            Console.WriteLine($"Age is {year} years,{month} months,{day} days");
        }
        public string ToString()
        {
            return String.Format("{0}/{1:D2}/{2:D2}", year, month, day);
        }
        public void print()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
}
