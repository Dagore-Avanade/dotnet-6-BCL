using System.Collections;

public class StackExample
{
    public static void Main()
    {
        // Stack: Represents a last in, first out (LIFO) collection of objects.
        Stack stack = new Stack();

        stack.Push("David");
        stack.Push("Pedro");
        stack.Push("María");

        Console.WriteLine($"Count: {stack.Count}");
        Console.WriteLine($"Retrieves and removes the last element with Pop: {stack.Pop()}");
        Console.WriteLine($"Retrieves without removing the last element with Peek: {stack.Peek()}");

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
