using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public class Dog : Animal
    {
        public string Name { get; set; }

        public Dog() : base(5)
        {
            Name = "QQ";
        }

        public Dog(string name) : base(5)
        {
            Name = name;
        }

        public Dog(int age, string name) : base(age)
        {
            Name = name;
        }
    }
}
