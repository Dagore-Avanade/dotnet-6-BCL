using System.Collections;

public class QueueExamples
{
    public static void Main()
    {
        // Queue: a first-in, first-out (FIFO) collection of objects. Implemented as a circular array, elements are sorted at one end and removed from the other.
        Queue queue = new Queue();

        queue.Enqueue("David");
        queue.Enqueue("Pedro");
        queue.Enqueue("María");

        Console.WriteLine($"Count: {queue.Count}");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine($"Dequeue returns and remove the first object in the queue: {queue.Dequeue()}");
        Console.WriteLine($"Peek returns without removing the first object in the queue: {queue.Peek()}");
        Console.WriteLine();
        Console.WriteLine("After the operations:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
