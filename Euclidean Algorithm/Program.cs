using ClassLibrary1;
using System;
//using Numbers;

namespace Euclidean_Algorithm
{
    internal class Program
    {
        //public static object Questions { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Euclidean Algorithm testing");
            //Console.WriteLine(Euclidean.Random());
            Console.WriteLine(Questions.q1());
            Rational r = Rational.Random();
            Console.WriteLine(r.ToString());
        }
    }
}
