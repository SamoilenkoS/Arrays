using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Student other))
            {
                throw new ArgumentException("Obj is not a student!");
            }

            return Age.CompareTo(other.Age);
        }
    }
}
