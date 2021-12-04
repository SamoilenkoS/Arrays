using ArraysLibrary;
using NUnit.Framework;
using System.IO;

namespace ArraysTests
{
    public class Tests
    {
        private IArrayList _arrayList;
        private void Initialize(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                _arrayList.AddBack(array[i]);
            }
        }

        [SetUp]
        public void Setup()
        {
            _arrayList = new ArrayList();
        }


        [TestCase(new[] { 1, 2, 3, 4})]
        public void Add_WhenElementsByElementAdded_ShouldFillArray(int[] sourceArray)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.Add(sourceArray[i]);
            }

            for (int i = 0; i < arrayList.Length; i++)
            {
                Assert.AreEqual(sourceArray[i], arrayList[i]);
            }
        }

        [TestCase(new[] { 1, 2, 3, 4 })]
        public void Add_WhenElementsAddedAsArray_ShouldFillArray(int[] sourceArray)
        {
            Initialize(sourceArray);

            for (int i = 0; i < _arrayList.Length; i++)
            {
                Assert.AreEqual(sourceArray[i], _arrayList[i]);
            }
        }

        [TestCase(new[] { 5, 3, 1, 2, 7 }, 7)]
        public void Max_WhenArrayAdded_ShouldFindMaxValue(int[] sourceArray, int expected)
        {
            Initialize(sourceArray);

            int actual = _arrayList.Max();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CastsExample()
        {
            PartialClass pk = new PartialClass();
            ArrayList array = new ArrayList();
            array.Add(3);
            array.Add(5);
            array.Add(4);
            foreach (var t in array)
            {

            }
            Animal a = new Cat(55, "Red");
            Animal b = new Cat(44, "Red");
            Animal c = new Dog(55, "Red");
            var test = a.Equals(b);
            var test2 = a.Equals(c);

            Dog d = a as Dog;
        }

        [Test]
        public void Main()
        {
            int a = 5;
            a.IsOdd();
            string hello = "Hello world test!";
            var updated = hello.UpdateString();
            AnimalCreator animalController = AnimalCreator.GetInstance();
            var cat = animalController.CreateCat();
            var dog = animalController.CreateDog();
            Another();
        }


        public void Another()
        {
            AnimalCreator animalController = AnimalCreator.GetInstance();
            var cat = animalController.CreateCat();
            var dog = animalController.CreateDog();
        }
    }
}