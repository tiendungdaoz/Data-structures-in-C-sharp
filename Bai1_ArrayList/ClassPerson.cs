using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_ArrayList
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

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
