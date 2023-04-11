using System.Collections.Concurrent;
public class ConcurrentStackDemo
{
    public static async void Main()
    {
        ConcurrentStack<int> stack = new();
        int items = 10000;
        Action pusher = () =>
        {
            for (int i = 0; i < items; i++)
            {
                stack.Push(i);
            }
        };

        // Run de action once.
        pusher();
        if (stack.TryPeek(out int result))
            Console.WriteLine($"TryPeek saw {result} on top of the stack.");
        else
            Console.WriteLine("Could not peek most recently added number.");
        
        stack.Clear();

        // Action to push and pop items
        Action pushAndPop = () =>
        {
            Console.WriteLine($"Task started on {Task.CurrentId}");

            for (int i = 0; i < items; i++) stack.Push(i);
            for (int i = 0; i < items; i++) stack.TryPop(out int item);

            Console.WriteLine($"Task ended on {Task.CurrentId}");
        };

        var tasks = new Task[5];
        for (int i = 0; i < tasks.Length; i++)
            tasks[i] = Task.Factory.StartNew(pushAndPop);

        // Wait for all tasks to finish up
        Task.WaitAll(tasks);

        if (!stack.IsEmpty)
            Console.WriteLine("Did not take all the items off the stack");
    }
}
