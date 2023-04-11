using System.Collections.Concurrent;
public class ConcurrentQueueDemo
{
    public static void Main()
    {
        ConcurrentQueue<int> queue = new();
        for (int i = 0; i < 10000; i++)
        {
            queue.Enqueue(i);
        }

        if (queue.TryPeek(out int result))
            Console.WriteLine($"Expected result of 0, got {result}");
        else
            Console.WriteLine("TryPeek failed");
        
        int outerSum = 0;
        // Action to consume the ConcurrentQueue.
        Action action = () =>
        {
            int localSum = 0;
            while (queue.TryDequeue(out int localValue)) localSum += localValue;
            // Add local sum with the outer sum.
            Interlocked.Add(ref outerSum, localSum);
        };
        // Start 4 concurrent consuming actions.
        Parallel.Invoke(action, action, action, action);

        Console.WriteLine($"outerSum = {outerSum}, should be 49995000");
    }
}
