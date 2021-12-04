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


    
    }
}
