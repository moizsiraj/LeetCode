using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Fibonacci
    {
        int fib(int n)
        {
            if (n <= 1) return n;
            return fib(n - 1) + fib(n - 2);
        }

        public int GetNthFib(int n)
        {

            if (n <= 1) return n;

            var array = new int[n];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }

            return array[n - 1];
        }

        public int Tribonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;
            if (n == 3) return 2;

            var array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;
            array[2] = 1;
            for (int i = 3; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2] + array[i - 3];
            }

            return array[n - 1];
        }
    }
}
