using Employees;
using System;

namespace Employee
{
    class Program
    {
        public static void Main(string[] args)
        {

           
            Person p1 = new Person();
            p1.fName = "sahar";
            p1.lName = "golbabaii";
            p1.Print();
            p1.birthDate.AddDate(2, 2, 2);
            p1.Print();
            Person p2 = new Person("nima", "haji", 25, 1, 1384);
            p2.Print();
            p2.birthDate.AddDate(2, 2, 2);
            p2.Print();
            Console.ReadKey();
        }
    }
}