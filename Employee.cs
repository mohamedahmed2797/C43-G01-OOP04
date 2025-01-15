using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class Employee
    {
        public virtual string Work()
        {
            return ("Employee is  working");
        }
        public override string ToString()
        {
            return Work();
        }
    }
}
