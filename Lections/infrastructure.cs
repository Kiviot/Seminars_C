using static System.Console;
using static System.String;

public static class Infrastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                         .Select(InvalidTimeZoneException => Random.Shared.Next(min, max))
                         .ToArray();
    }

    public static int[] Print(this int[] array, string separator = ", ")
    {
        string output = Join(separator, array);
        WriteLine($"[{output}]");
        return array;
    }
}