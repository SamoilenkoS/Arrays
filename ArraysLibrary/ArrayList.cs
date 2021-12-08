using System;
using System.Collections;
using System.Collections.Generic;

namespace ArraysLibrary
{
    public class ArrayList : IArrayList
    {
        private int[] _array;

        private int _currentCount;

        public int Length => _currentCount;

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _currentCount)
                {
                    return _array[index];
                }

                throw new ArgumentOutOfRangeException("Index was out of range!");
            }
            set
            {
                //
            }
        }

        public ArrayList()
        {
            _array = new int[5];
            _currentCount = 0;
        }

        public ArrayList(int[] array)
        {
            int size = (int)(array.Length * 1.33);
            _array = new int[size];
            _currentCount = array.Length;

            for (int i = 0; i < _currentCount; i++)
            {
                _array[i] = array[i];
            }
        }

        public void AddFront(int element)
        {
            AddByIndex(0, element);
        }

        public void AddBack(int element)
        {
            UpdateSize();

            _array[_currentCount++] = element;
        }

        public void AddByIndex(int index, int element)
        {
            UpdateSize();

            for (int i = _currentCount; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;

            _currentCount++;
        }

        public void AddBack(IArrayList arrayList)
        {
            var array = arrayList.ToArray();
            UpdateSize(array.Length);

            for (int i = _currentCount, j = 0; j < array.Length; i++, j++)
            {
                _array[i] = array[j];
            }

            _currentCount += array.Length;
        }

        public int DeleteByValue(int value)
        {
            int index = -1;
            for (int i = 0; i < _currentCount; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    break;
                }
            }

            --_currentCount;
            for (int i = index; i < _currentCount; i++)
            {
                _array[i] = _array[i + 1];
            }

            return index;
        }

        public int Max()
        {
            int maxI = MaxI();
            if(maxI == -1)
            {
                throw new ArgumentException("Array is empty!");
            }

            return _array[maxI];
        }

        public int MaxI()
        {
            if (_currentCount == 0)
            {
                return -1;
            }

            int maxI = 0;
            for (int i = 1; i < _currentCount; i++)
            {
                if (_array[maxI] < _array[i])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public int Min()
        {
            int minI = MinI();
            if (minI == -1)
            {
                throw new ArgumentException("Array is empty!");
            }

            return _array[minI];
        }

        public int MinI()
        {
            if (_currentCount == 0)
            {
                return -1;
            }

            int minI = 0;
            for (int i = 1; i < _currentCount; i++)
            {
                if (_array[minI] > _array[i])
                {
                    minI = i;
                }
            }

            return minI;
        }

        public void Print()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }

        public int RemoveFront()
        {
            throw new NotImplementedException();
        }

        public int RemoveBack()
        {
            throw new NotImplementedException();
        }

        public int RemoveByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveFront(int count)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveBack(int count)
        {
            throw new NotImplementedException();
        }

        public int[] RemoveByIndex(int index, int count)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int element)
        {
            int result = -1;
            for (int i = 0; i < _currentCount; i++)
            {
                if(_array[i] == element)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public void Sort(bool ascending = true)
        {
            throw new NotImplementedException();
        }

        public int Remove(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveAll(int value)
        {
            throw new NotImplementedException();
        }

        public void AddFront(IArrayList arrayList)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, IArrayList arrayList)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int[] ToArray()
        {
            int[] result = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                result[i] = _array[i];
            }

            return result;
        }

        private void UpdateSize(int countToAdd = 1)
        {
            if ((_currentCount + countToAdd) >= _array.Length)
            {
                int newSize = (int)((_array.Length + countToAdd) * 1.33);
                int[] newArray = new int[newSize];
                for (int i = 0; i < _currentCount; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }
        }
    }
}