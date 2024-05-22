﻿using System;
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
        public string fullName
        {
            get { return fName + " " + lName; }
        }
        public Person()
        {
            fName = ""; lName = "";
            birthDate = new MyDate();
        }
        public Person(string fname, string lname, int day, int m, int y)
        {
            fName = fname; lName = lname;
            birthDate = new MyDate(day, m, y);
        }
        
        public void Print()
        {
            Console.WriteLine("Person Information:\n First name:{0}, Last Name:{1}", fName, lName);
            Console.WriteLine("Birth Day: {0}", birthDate.ToString());
        }


    }
}
