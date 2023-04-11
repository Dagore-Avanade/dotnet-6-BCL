/*
    Collections VS Collections.Generic
    ArrayList => List<T>
    HashTable => Dictionary<TKey, TValue>, ConcurrentDictionary<TKey, TValue>
    CollectionBase => Collection<T>
    Queue => Queue<T>
    Stack => Stack<T>
    ...
*/
using System.Collections;
ArrayList arrayList = new ArrayList()
{
    "one", 1, null
};
List<string> list = new()
{
    "one", "1", "null"
};
// Does not compile
// list.Add(1);

// I can use the list to create a collection of a custom type a use the elements within and all its method and properties without need of a type cast.
List<Car> carList = new()
{
    new Car(7392, 2, 4, 2, "yellow"),
    new Car(4529, 3, 3, 3, "red"),
    new Car(4923, 2, 4, 2, "green")
};
foreach (Car car in carList)
{
    Console.WriteLine(car);
}

// Instead of HashTable use Dictionary:
Dictionary<string, string> carDict = new()
{
    { "Mustang", "red" },
    { "Series", "white" },
    { "Chevy", "green" },
    { "Frontier", "white" }
};
// Does not compile
// carDict.Add("Mondeo", 42 );
foreach (KeyValuePair<string, string> item in carDict)
{
    Console.WriteLine(item);    
}
// Consider HashSet to store unique values.
HashSet<int> numbersSet = new();
for (int i = 0; i < 10; i++)
{
    numbersSet.Add(i);
}
// Does not thrown an error: the Add method is idempotent.
numbersSet.Add(2);
foreach (int number in numbersSet)
{
    Console.WriteLine(number);
}
// Stack and Queue works almost as their not generic version.
