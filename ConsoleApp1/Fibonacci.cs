using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Fibonacci
    {
        public long Fib(long n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {   
                return Fib(n-1) + Fib(n-2);
            }
        }

        public BigInteger Fib1 (BigInteger n)
        {
           
            BigInteger x = 0;
            BigInteger y = 1;
            BigInteger result = 1;

            if (n <= 1)
            {
                return n;
            }
            for (int i = 0; i < n-1; i++)
            {
                result = y + x;
                x = y;
                y = result;
            }
            return result;
        }

        public BigInteger FibWithDynamic (BigInteger n)
        {
            BigInteger[] a = new BigInteger[(int)n+2];
            int i;

            a[0] = 0;
            a[1] = 1;

            for(i =2; i<= n; i++)
            {
                a[i] = a[i-2] + a[i-1];
            }

            return a[(int)n];

        }

       
    }
}
