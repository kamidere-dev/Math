using System;

namespace Euclidean_Algorithm
{
    internal class Questions
    {
        internal static bool q1()
        {
            int n = 0;
            while (n < 100)
            {
                double q = Math.Pow(n, 2) + 2 * n + 3;
                double p = 3 * q - 2 * Math.Pow(n, 2);
                Console.WriteLine("n =" + n);
                Console.WriteLine("3(" + n + "^2 + 2" + n + " + 3) - 2 * " + n + "^2 = " + p);
                Console.WriteLine("sqrt = " + Math.Sqrt(p));
                n++;
            }
            throw new NotImplementedException();
        }
    }
}