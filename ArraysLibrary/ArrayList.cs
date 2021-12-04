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

        public void Add(int number)
        {
            if (_currentCount != _array.Length)
            {
                _array[_currentCount] = number;
            }
            else
            {
                int[] newArray = new int[(int)(_array.Length * 1.33)];
                for (int i = 0; i < _array.Length; i++)
                {
                    newArray[i] = _array[i];
                }

                newArray[_currentCount] = number;
                _array = newArray;
            }

            ++_currentCount;
        }

        public void Add(int[] array)
        {
            //
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
            return 0;
        }

        public void Print()
        {
            for (int i = 0; i < _currentCount; i++)
            {
                Console.Write($"{_array[i]} ");
            }
        }

        public void AddFront(int element)
        {
            throw new NotImplementedException();
        }

        public void AddBack(int element)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int element)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int MaxI()
        {
            throw new NotImplementedException();
        }

        public int MinI()
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

        public void AddBack(IArrayList arrayList)
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
    }
}
