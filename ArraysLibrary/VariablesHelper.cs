using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public class VariablesHelper
    {
        public static int count;

        static VariablesHelper()
        {
            count = 0;
        }

        public VariablesHelper()
        {
            ++count;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Max(int a, int b)
        {
            if(a > b)
            {
                return a;
            }

            return b;
        }

        public static T Max<T>(T a, T b)
            where T : IComparable
        {
            return a.CompareTo(b) == 1 ? a : b;
        }

        public static double Max(double a, double b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

    }
}
