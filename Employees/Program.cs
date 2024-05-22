using Employees;
using System;

namespace Employee
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*MyDate d1=new MyDate();
            Console.WriteLine("Date:{0}/{1}/{2}",d1.Year,d1.Month,d1.Day);
            Console.WriteLine("Your Date:"+d1.ToString());
            d1.Year=1400;
            d1.Day=40;
            d1.print();
            MyDate d2=new MyDate(13,10,1401);
            d2.print();
            d2.Day=Convert.ToInt16(Console.ReadLine());
            */
            Person p1;
            p1 = new Person();
            p1.Print();
            Person p2 = new Person("Sahar", "Golbabaeii", 12, 15, 1382);
            p2.Print();
            Console.WriteLine(p2.fullName);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}