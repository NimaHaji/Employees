using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class MyDate
    {
        private int day, month, year;
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
        public static void AddDate(Person person, int d,int m,int y)
        {
            person.birthDate.day += d;
            person.birthDate.month += m;
            person.birthDate.year += y;
        }
        public void AddDate(int d, int m, int y)
        {
            day += d;
            month += m;
            year += y;
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
