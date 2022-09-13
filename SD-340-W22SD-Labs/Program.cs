LinkedList<int> ints = new LinkedList<int>(1, 2);
ints.PrintValues();

class LinkedList<T>
{
    public T FirstNode { get; set; }
    public T SecondNode { get; set; }
    public LinkedList(T first, T second)
    {
        FirstNode = first;
        SecondNode = second;
    }

    public void PrintValues()
    {
        Console.WriteLine($"Values: {FirstNode.ToString()} and {SecondNode.ToString()}");
    }
}