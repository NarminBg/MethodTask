using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionMethods
{
    internal static class Class1
    {
        public static int GetSquares(this int s)
        {
            return s * s;

        }
    }
}
