using System.Linq;

namespace ProjectEuler
{
    class Euler004
    {
        public int Solve()
        {
            int result = 0;
            string testString = "";
            int testVal = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    testVal = (i * j);
                    testString = testVal.ToString();
                    if (testVal > result)
                    {
                        if (testString == new string(testString.ToCharArray().Reverse().ToArray()))
                        {
                            result = testVal;
                        }
                    }
                    
                }
            }
            return (result);
        }
        

    }
}
