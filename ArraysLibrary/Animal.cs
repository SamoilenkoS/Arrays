using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public abstract class Animal
    {
        public int Age { get; set; }

        public Animal(int age)
        {
            Age = age;
        }
    }
}
