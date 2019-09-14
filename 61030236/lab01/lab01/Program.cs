using System;

namespace lab01
{
    class Program
    {
        private const int MaxValue = 9;

        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, MaxValue);
            Console.WriteLine(randomNumber);
            bool a = 0 > 9;
            Console.WriteLine("{0}", a);
        }
    }
}
