using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    static class Fibonacci
    {
        public static int GetElement(int n)
        {
            if (n == 1) return 0;
            if (n <= 3) return 1;
            else return GetElement(n - 1) + GetElement(n - 2); 
        }
    }
}
