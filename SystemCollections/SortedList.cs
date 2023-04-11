using System.Collections;

public class SortedListExamples
{
    public static void Main()
    {
        // SortedList: Collection of key/value pairs tat are sorted by the keys. Accesible by key and by index. Uses two arrays under the hood.
        SortedList sortedList = new SortedList()
        {
            {3, "Tres"},
            {1, "Uno"},
            {5, "Cinco"},
            {2, "Dos"}
        };

        Console.WriteLine($"Count: {sortedList.Count}");
        Console.WriteLine($"Capacity: {sortedList.Capacity}");

        foreach (var item in sortedList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"In first position: [{sortedList.GetKey(0)}, {sortedList.GetByIndex(0)}]");
    }
}
