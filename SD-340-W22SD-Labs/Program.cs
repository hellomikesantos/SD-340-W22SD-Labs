LinkedList<int> ints = new LinkedList<int>(1, 2, 3);
LinkedList<int> ints2 = new LinkedList<int>(20, 30, 40);

ints.PrintValues();
ints2.PrintValues();

class LinkedList<T>
{
    public T FirstNode { get; set; }
    public T SecondNode { get; set; }
    public T ThirdNode { get; set; }
    public LinkedList(T first, T second, T thirdNode)
    {
        FirstNode = first;
        SecondNode = second;
        ThirdNode = thirdNode;
    }

    public void Add(int value)
    {
        this.Add(value);
    }
    public void PrintValues()
    {
        Console.WriteLine($"Values: {FirstNode.ToString()}, {SecondNode.ToString()}, and {ThirdNode.ToString()}");
    }
}

