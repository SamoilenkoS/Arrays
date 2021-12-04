using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public interface IArrayList : IEnumerable<int>
    {
        void AddFront(int element);
        void AddBack(int element);
        void AddByIndex(int index, int element);//1
        /// <summary>
        /// Removing element from begining
        /// </summary>
        /// <returns>Returns removed element</returns>
        int RemoveFront();
        int RemoveBack();
        int RemoveByIndex(int index);//2
        int[] RemoveFront(int count);
        int[] RemoveBack(int count);
        int[] RemoveByIndex(int index, int count);//3
        int Length { get; }//4
        int this[int index] { get; set; }//5,6
        int IndexOf(int element);//7
        void Reverse();//8
        int Max();
        int Min();
        int MaxI();//9
        int MinI();//10
        void Sort(bool ascending = true);//11
        /// <summary>
        /// Remove first element by value
        /// </summary>
        /// <param name="value">Value to remove</param>
        /// <returns>Index of removed element</returns>
        int Remove(int value);//12
        /// <summary>
        /// Remove all elements by value
        /// </summary>
        /// <param name="value">Value to remove</param>
        /// <returns>Count of removed elements</returns>
        int RemoveAll(int value);//13
        void AddFront(IArrayList arrayList);
        void AddBack(IArrayList arrayList);
        void AddByIndex(int index, IArrayList arrayList);//14
    }
}
