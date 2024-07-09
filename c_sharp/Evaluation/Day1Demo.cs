namespace Evaluation;

public class Day1Demo
{
    public enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter
    }


    public int OptionalVal(int a, int b = 20)
    {
        return a + b;
    }

    public void PassByRef(ref int val)
    {
        val = 100;
    }
    
    public int MyAdd(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    public int OutTest(int a, out int b, out int c)
    {
        b = a * a;
        c = (int) Math.Pow(a, a);
        a += 10;
        return a;
    }
}