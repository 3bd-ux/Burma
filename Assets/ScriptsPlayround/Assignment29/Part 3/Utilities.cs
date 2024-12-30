using System.Linq;

public static class Utilities
{
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    public static string RepeatString(this string input, int count)
    {
        return string.Concat(Enumerable.Repeat(input, count));
    }
}