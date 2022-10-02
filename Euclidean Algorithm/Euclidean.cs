using System;

namespace Euclidean_Algorithm
{
    internal class Euclidean
    {
        internal static string Random()
        {
            Random rnd = new Random();
            return Algorithm(rnd.Next(1, 1000000), rnd.Next(1, 1000000));
        }

        private static string Algorithm(int v1, int v2)
        {
            //prints all the steps of the euclidean algorithm
            throw new NotImplementedException();
        }
    }
}