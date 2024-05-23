using System;

namespace Fibonacci
{
    public class Progam
    {
        static void Main(string[] args)
        {
            Fibonacci(3);
         }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return 1;

            var result = Fibonacci(n - 1) + Fibonacci(n - 2);
            Console.WriteLine(result);
            return result;
        }
    }
}
