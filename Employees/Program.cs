using Employees;
using System;

namespace Employee
{
    class Program
    {
        public static void Main(string[] args)
        {


            Person hesam = new Person("hesam", "ebrahimi", 3, 11, 1383);
            Person nima = new Person("nima", "haji", 25, 1, 1384);
            Person ali = new Person("ali", "alipor", 30, 2, 1382);
            Person mohsen = new Person("mohsen", "miri", 20, 11, 1383);
            Person[] persons = { hesam, nima, ali, mohsen };
            persons= Person.SortArray(persons);
            foreach(var i in persons)
            {
                i.Print();
            }
            
            Console.ReadKey();
        }
    }
}