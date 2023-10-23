using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_SortedList
{
    internal class Person
    {
        private int age;
        private string name;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }

        //Tao 1 constructor co tham so
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        //Override lai phuong thuc TosTring cua object
        public override string ToString()
        {
            return "Name: " + name + " | Age " + age;
        }
    }
}
