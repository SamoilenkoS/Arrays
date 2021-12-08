using ArraysLibrary;
using NUnit.Framework;
using System;
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


        [TestCase(new[] { 1, 2, 3, 4 })]
        public void AddBack_WhenElementsByElementAdded_ShouldFillArray(int[] sourceArray)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < sourceArray.Length; i++)
            {
                arrayList.AddBack(sourceArray[i]);
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

        [TestCase(new[] { 5, 3, 1, 2, 7 }, 1)]
        [TestCase(new[] { 5 }, 5)]
        [TestCase(new[] { 5, -5, 0 }, -5)]
        public void Min_WhenArrayAdded_ShouldFindMinValue
            (int[] sourceArray, int expected)
        {
            Initialize(sourceArray);

            int actual = _arrayList.Min();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 5, 3, 1, 2, 7 }, 1, 2)]
        [TestCase(new[] { 5 }, 5, 0)]
        [TestCase(new[] { 5, -5, 0 }, -5, 1)]
        [TestCase(new[] { 5, 5, 5 }, 5, 0)]
        [TestCase(new[] { 5, -5, 0 }, 0, 2)]
        [TestCase(new[] { 5, -5, 0 }, 10, -1)]
        [TestCase(new int[] { }, 0, -1)]
        public void IndexOf_WhenCalled_ShouldFindIndexOfElement
            (int[] sourceArray, int searchValue, int expectedIndex)
        {
            Initialize(sourceArray);

            int actualIndex = _arrayList.IndexOf(searchValue);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCase(
            new[] { 1, 2, 3, 4, 5 },
            new[] { 6, 7, 8 },
            new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        public void AddBack_WhenArrayAdded_ShouldAddArrayElementsToEnd(
            int[] sourceArray,
            int[] arrayToAdd,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            _arrayList.AddBack(new ArrayList(arrayToAdd));

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
        }

        [TestCase(new int[] { },
            1,
            new[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 },
            4,
            new[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 },
            5,
            new[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            6,
            new[] { 6, 1, 2, 3, 4, 5 })]
        public void AddFront_WhenElementAdded_ShouldAddElementToFront(
            int[] sourceArray,
            int elementToAdd,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            _arrayList.AddFront(elementToAdd);

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
        }

        [TestCase(new int[] { },
            1,
            0,
            new[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 },
            4,
            1,
            new[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 },
            5,
            4,
            new[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            6,
            0,
            new[] { 6, 1, 2, 3, 4, 5 })]
        public void AddByIndex_WhenElementAdded_ShouldAddElementToIndexPosition(
            int[] sourceArray,
            int elementToAdd,
            int index,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            _arrayList.AddByIndex(index, elementToAdd);

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
        }

        [TestCase(new[] { 1 }, 0, 1, new int[] { })]
        [TestCase(new int[] { 5, 2, 3 }, 0, 5, new[] { 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, 3, new[] { 1, 2, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, 5, new[] { 1, 2, 3, 4 })]
        public void RemoveByIndex_WhenValidIndex_ShouldRemoveElementByIndex(
            int[] sourceArray,
            int indexToDelete,
            int expectedDeleted,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            int actualDeleted =
                _arrayList.RemoveByIndex(indexToDelete);

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
            Assert.AreEqual(expectedDeleted, actualDeleted);
        }

        [TestCase(new[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 2, 3 }, 5, new[] { 2, 3 })]
        [TestCase(new int[] { 3, 2, 3, 4 }, 3, new[] { 2, 3, 4 })]
        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 8, new[] { 2, 3, 4, 5 })]
        public void RemoveFront_WhenValidIndex_ShouldRemoveFirstElement(
            int[] sourceArray,
            int expectedDeleted,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            int actualDeleted =
                _arrayList.RemoveFront();

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
            Assert.AreEqual(expectedDeleted, actualDeleted);
        }

        [TestCase(new[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 5, 2, 3 }, 3, new[] { 5, 2 })]
        [TestCase(new int[] { 3, 2, 3, 4 }, 4, new[] { 3, 2, 3 })]
        [TestCase(new int[] { 8, 2, 3, 4, 5 }, 5, new[] { 8, 2, 3, 4 })]
        public void RemoveBack_WhenValidIndex_ShouldRemoveFirstElement(
            int[] sourceArray,
            int expectedDeleted,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            int actualDeleted =
                _arrayList.RemoveBack();

            Assert.AreEqual(expectedArray, _arrayList.ToArray());
            Assert.AreEqual(expectedDeleted, actualDeleted);
        }

        [TestCase(new[] { 1 }, 1, 0, new[] { 1 }, new int[] { })]
        [TestCase(new int[] { 5, 2, 3 }, 2, 0, new[] { 5, 2 }, new[] { 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },
            3, 2,
            new[] { 3, 4, 5 }, new[] { 1, 2, 6, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5},
            3, 2,
            new[] { 3, 4, 5 }, new[] { 1, 2 })]
        public void RemoveCountByIndex_WhenValidInput_ShouldRemoveCountElementStartingFromIndex(
            int[] sourceArray,
            int count,
            int index,
            int[] expectedDeleted,
            int[] expectedArray)
        {
            Initialize(sourceArray);

            int[] actualDeleted =
                _arrayList.RemoveByIndex(index, count);

            Assert.AreEqual(expectedDeleted, actualDeleted);
            Assert.AreEqual(expectedArray, _arrayList.ToArray());
        }

        [Test]
        public void RemoveBack_WhenInvalidIndex_ShouldThrowArgumentException()
        {
            Initialize(new int[] { });

            try
            {
                _arrayList.RemoveBack();
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("Array is empty or index is incorrect!",
                    ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}