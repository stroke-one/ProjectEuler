public class Euler002
{
    private int maxValue;

    public Euler002(int maxValue)
    {
        this.maxValue = maxValue;
    }
    public int Solve()
    {
        int a = 0;
        int b = 1;
        int c = 0;
        int result = 0;

        while (c < this.maxValue)
        {
            c = a + b;
            a = b;
            b = c;
            if (c % 2 == 0)
            {
                result += c;
            }
        }
        return (result);
    }
}
