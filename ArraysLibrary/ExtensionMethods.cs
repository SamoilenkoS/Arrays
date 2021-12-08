using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysLibrary
{
    public static class ExtensionMethods
    {
        public static string UpdateString(this string str)
        {
            string[] parts = str.Split(' ');
            parts[0] = parts[0].ToUpper();

            return string.Join(' ', parts);
        }

        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
    }
}
