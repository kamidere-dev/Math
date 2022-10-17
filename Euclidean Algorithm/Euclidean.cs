using System;

namespace Euclidean_Algorithm
{
    internal class Euclidean
    {
        internal static string Random()
        {
            Random rnd = new Random();
            return "" + Algorithm(rnd.Next(1, 1000000), rnd.Next(1, 1000000));
        }

        private static int Algorithm(int v1, int v2)
        {
            //prints all the steps of the euclidean algorithm
            string s = "gcd(" + v1 + ", " + v2 + ")";
            Console.WriteLine(s);
            if (v1 == v2)
            {
                return v1;
            }
            else if (v2 > v1)
            {
                int i = 0;
                while (i * v1 < v2)
                {
                    i++;
                    Console.WriteLine(i + " * " + v1 + " = " + i * v1);
                }
                i--;
                int product = i * v1;
                int remainder = v2 - product;
                return Algorithm(v1, remainder);
            }
            else
            {
                return Algorithm(v2, v1);
            }
            throw new Exception(s);
        }
    }
}