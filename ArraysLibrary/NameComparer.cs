using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ArraysLibrary
{
    public class NameComparer : IComparer<Student>
    {
        private readonly int _ascending;
        public NameComparer(bool ascending = true)
        {
            _ascending = ascending ? 1 : -1;
        }

        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            return x.FirstName.CompareTo(y.FirstName) * _ascending;
        }
    }
}
