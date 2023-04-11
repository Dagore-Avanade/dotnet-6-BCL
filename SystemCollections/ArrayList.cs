using System.Collections;

public class ArrayListExamples
{
    public static void Main()
    {
        // ArrayList: Array with a size that's dynamically increased as required. Designed to hold heterogeneous collections of objects. List<T> for homogeneous.
        ArrayList anArrayList = new ArrayList();
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            anArrayList.Add(random.Next());
        }
        Console.Write($"Print {anArrayList}: ");
        foreach (var item in anArrayList)
        {
            Console.Write(item + "\t");
        }
        Console.WriteLine();
        Console.WriteLine($"Count: {anArrayList.Count}");
        Console.WriteLine($"Capacity: {anArrayList.Capacity}");
    }
}
