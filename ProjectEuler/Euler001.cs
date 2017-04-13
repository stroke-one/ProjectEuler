public class Euler001
{
    private int maxValue;

    public Euler001(int max_number)
    {
        this.maxValue = max_number;
    }

    public int Solve()
    {
        int result = 0;
        for (int i = 1; i < this.maxValue; i++)
        {
            if (i % 3 == 0)
            {
                result = result + i;
            }
            else if (i % 5 == 0)
            {
                result = result + i;
            }

        }
        return (result);
    }
}