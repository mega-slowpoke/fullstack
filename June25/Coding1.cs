namespace Main;

public class Coding1
{
    
    public static int[] GenerateNumbers(int size)
    {
        int[] res = new int[size];
        for (int i = 0; i < size; i++)
        {
            res[i] = i;
        }
        return res;
    }

    public static void Reverse(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }

    public static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}