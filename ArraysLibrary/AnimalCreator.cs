using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public sealed class AnimalCreator
    {
        private static AnimalCreator Instance = new AnimalCreator();
        private int _catsCount;
        private int _dogsCount;

        private AnimalCreator()
        {
            _catsCount = 0;
            _dogsCount = 0;
        }

        public static AnimalCreator GetInstance()
        {
            return Instance;
        }

        public Dog CreateDog()
        {
            _dogsCount++;
            return new Dog();
        }

        public Cat CreateCat()
        {
            _catsCount++;
            return new Cat(5, "Red");
        }
    }
}
