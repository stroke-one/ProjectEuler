using System;

namespace Euler_002
{
    class Euler_002
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int result = 0;

            int maxValue = 4000000;
            while (c < maxValue)
            {
                c = a + b;
                a = b;
                b = c;
                if (c % 2 == 0)
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
