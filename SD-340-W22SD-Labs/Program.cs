LinkedList<int> ints = new LinkedList<int>(1, 2);
ints.PrintValues();

class LinkedList<T>
{
    public T First { get; set; }
    public T Second { get; set; }
    public LinkedList(T first, T second)
    {
        First = first;
        Second = second;
    }

    public void PrintValues()
    {
        Console.WriteLine($"Values: {First.ToString()} and {Second.ToString()}");
    }
}