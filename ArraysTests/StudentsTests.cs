using ArraysLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysTests
{
    public class StudentsTests
    {
        [Test]
        public void Students_Tests()
        {
            Student vasya = new Student
            {
                FirstName = "Vasya",
                LastName = "Pupkin",
                Age = 30
            };

            Student petya = new Student
            {
                FirstName = "Petya",
                LastName = "Fedorov",
                Age = 20
            };

            Student ivan = new Student
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Age = 40
            };

            Student dima = new Student
            {
                FirstName = "Dima",
                LastName = "Ivanov",
                Age = 10
            };

            Student[] students = new Student[4];
            students[0] = vasya;
            students[1] = petya;
            students[2] = ivan;
            students[3] = dima;

            Array.Sort(students, new NameComparer(false));
        }
    }
}
