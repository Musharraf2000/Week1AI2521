using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1AI2521
{
    internal class Customer
    {
        public string name;
        public int age;
        public bool isStudent;

        public Customer(string name, int age, bool isStudent)
        {
            this.name = name;
            this.age = age;
            this.isStudent = isStudent;
        }
    }
}
