using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Teacher : Person
    {
        public Teacher (string firstname, string lastname, int salary):base(firstname, lastname)
        {
            Salary = salary;
        }
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        

    }
}
