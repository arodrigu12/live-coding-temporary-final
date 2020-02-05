using System;

namespace HowMuchCandyToBuy
{
    class Program
    {
        static void Main(string[] args)
        {

            double candy = 1.1 * 250 * 3;

            Console.WriteLine("If weather clear and in the 50's you buy " + candy.ToString());

            candy = 1.2 * 250 * 3;

            Console.WriteLine("If full moon and in the 40s you buy " + candy.ToString());

            candy = .95 * 250 * 3;

            Console.WriteLine("rainy and in the 70s you buy " + candy.ToString());

            Console.ReadLine();
        }
    }
}
