using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArraysLibrary
{
    public class Cat : Animal, IEquatable<Cat>
    {
        public string Color { get; set; }
        public Cat(int age, string color) : base(age)
        {
            Color = color;
        }

        public override bool Equals(object obj)
        {
            Cat cat = obj as Cat;

            return Equals(cat);
        }

        public bool Equals([AllowNull] Cat other)
        {
            return other != null && other.Age == Age && other.Color == Color;
        }
    }
}
