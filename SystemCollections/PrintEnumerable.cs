using System.Collections;

public static class PrintEnumerable
{
    public static void PrintValues(IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
