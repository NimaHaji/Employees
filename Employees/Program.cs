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
            Console.WriteLine("--------------------------------------");
            Member hesamebrahimi = new Member(1,1,1,1380);
            hesamebrahimi.fName = "Hesam";
            hesamebrahimi.lName = "Hesam";
            Member aliazimi = new Member(2, 1, 2, 1380);
            hesamebrahimi.fName = "ali";
            hesamebrahimi.lName = "azimi";
            Member mohsenalipor = new Member(3, 5, 3, 1390);
            hesamebrahimi.fName = "mohsen";
            hesamebrahimi.lName = "alipor";
            Member[] members = { hesamebrahimi, aliazimi, mohsenalipor };
            for(int i=0;i<persons.Length;i++)
            {
                Console.WriteLine($"name is {persons[i].fullName}");
                Console.WriteLine($"hire date is year : {persons[i].AgeYears} month : {persons[i].AgeMonths} day : {persons[i].AgeDays}");
            }
            Console.ReadKey();
        }
    }
}