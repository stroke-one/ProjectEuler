using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Euler001 euler001 = new Euler001(1000);
            Console.WriteLine(string.Format("Euler001\t{0}", (euler001.Solve())));

            Euler002 euler002 = new Euler002(4000000);
            Console.WriteLine(string.Format("Euler002\t{0}", (euler002.Solve())));

            Euler003 euler003 = new Euler003(600851475143);
            Console.WriteLine(string.Format("Euler003\t{0}", (euler003.Solve())));

            Euler007 euler007 = new Euler007(10001);
            Console.WriteLine(string.Format("Euler007\t{0}", (euler007.Solve())));

            Euler010 euler010 = new Euler010(2000000);
            Console.WriteLine(string.Format("Euler010\t{0}", (euler010.Solve())));

        }
    }
}
