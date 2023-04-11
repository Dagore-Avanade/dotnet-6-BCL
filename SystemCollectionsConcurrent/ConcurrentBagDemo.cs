using System.Collections.Concurrent;
public class ConcurrentBagDemo
{
    // Unordered collection of a specific type. Supports duplicates.
    public static void Main ()
    {
        // Add to bag concurrently.
        ConcurrentBag<int> bag = new();
        List<Task> bagAddTasks = new();
        for (int i = 0; i < 50; i++)
        {
            int numberToAdd = i;
            bagAddTasks.Add(Task.Run(() => bag.Add(numberToAdd)));
        }

        // Wait for all tasks to complete
        Task.WaitAll(bagAddTasks.ToArray());
        Console.WriteLine("All tasks have completed");

        // Consume the items in the bag.
        List<Task> bagConsumeTasks = new();
        int itemsInBag = 0;
        while (!bag.IsEmpty)
        {
            bagConsumeTasks.Add(Task.Run(() => {
                // Try to return and remove an item from the bag, TryPeek also exists to return without removing.
                if (bag.TryTake(out int item))
                {
                    Console.WriteLine(item);
                    itemsInBag++;
                }
            }));
        }
        Task.WaitAll(bagConsumeTasks.ToArray());
        Console.WriteLine($"There were {itemsInBag} items in the bag");

        // Checks for an item in the bag, which should be empty.
        if (bag.TryPeek(out int unexpectedItem))
            Console.WriteLine("Found an item in the bag when it should be empty");
        else
            Console.WriteLine("The bag is empty");
    }
}
