using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop2
{
    internal struct person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public person(int age, string name)
        {
            this.age = age;
            this.name = name;

        }
        public override string ToString()
        {
            return $" name ={name}\n age={age}  ";
        }
    }
}
