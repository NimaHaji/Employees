using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Person
    {
        public string fName, lName;
        public MyDate birthDate;
        public int AgeYears, AgeMonths, AgeDays;
        public string fullName
        {
            get { return fName + " " + lName; }
        }
        public Person()
        {
            fName = ""; lName = "";
            birthDate = new MyDate();
            AgeYears = birthDate.Year;
            AgeMonths = birthDate.Month;
            AgeDays = birthDate.Day;
        }
        public Person(string fname, string lname, int day, int m, int y)
        {
            fName = fname; lName = lname;
            birthDate = new MyDate(day, m, y);
            AgeYears = birthDate.Year;
            AgeMonths = birthDate.Month;
            AgeDays = birthDate.Day;
        }

        public void Print()
        {
            Console.WriteLine("Person Information:\n First name:{0}, Last Name:{1}", fName, lName);
            Console.WriteLine("Birth Day: {0}", birthDate.ToString());
            birthDate.Age();
        }

        public static Person[] SortArray(Person[] persons)
        {
            Person tempP = persons[0];
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = 0; j < persons.Length - i - 1; j++)
                {
                    if (persons[j].AgeYears < persons[j + 1].AgeYears ||
                        (persons[j].AgeYears == persons[j + 1].AgeYears && persons[j].AgeMonths < persons[j + 1].AgeMonths) ||
                        (persons[j].AgeYears == persons[j + 1].AgeYears && persons[j].AgeMonths == persons[j + 1].AgeMonths && persons[j].AgeDays < persons[j + 1].AgeDays))
                    {
                        tempP = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = tempP;
                    }
                }
            } 
                return persons;
        }
    }
}
