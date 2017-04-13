using System;


namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Euler001 euler001 = new Euler001(1000);
            Console.WriteLine(euler001.Solve());

            Euler002 euler002 = new Euler002(4000000);
            Console.WriteLine(euler002.Solve());

            Euler003 euler003 = new Euler003(600851475143);
            Console.WriteLine(euler003.Solve());
        }
    }
}
