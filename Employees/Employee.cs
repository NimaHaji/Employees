using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public class Employee:Person
    {
        private int IdNumber;
        public int Id
        {
            get { return IdNumber; }
            set { IdNumber = value; }
        }
        MyDate hireDate;
        public Employee(int iD, int day, int m, int y) : base()
        {
            IdNumber = iD;
            hireDate = new MyDate(day, m, y);
        }
    }
}
