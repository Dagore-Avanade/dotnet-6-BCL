using System.Collections;
public class HashtableExamples
{
    public static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("A key", "A Value");
        hashtable.Add(4, "Cuatro");

        foreach (DictionaryEntry item in hashtable)
        {
            Console.WriteLine(item);
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }

        IEnumerable keys = hashtable.Keys;
        IEnumerable values = hashtable.Values;

        Console.WriteLine();
        Console.WriteLine("Keys");
        PrintEnumerable.PrintValues(keys);
        Console.WriteLine();
        Console.WriteLine("Values");
        PrintEnumerable.PrintValues(values);

        try
        {
            hashtable.Add(4, "4");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // This is the right way to update a key / value pair.
        hashtable[4] = "4";
        Console.WriteLine(hashtable[4]);

    }
}
