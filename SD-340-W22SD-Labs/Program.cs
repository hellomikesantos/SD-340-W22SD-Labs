LinkedList<int> ints = new LinkedList<int>(1, 2, 3);
LinkedList<int> ints2 = new LinkedList<int>(20, 30, 40);

ints.PrintValues();
ints2.PrintValues();

public class LinkedList<T>
{
    Node head;
    public class Node
    {
        public T data;
        public Node next;

        public Node(T value)
        {
            data = value;
            next = null;
        }
    }
    public T FirstNode { get; set; }
    public T SecondNode { get; set; }
    public T ThirdNode { get; set; }
    public LinkedList(T first, T second, T thirdNode)
    {
        FirstNode = first;
        SecondNode = second;
        ThirdNode = thirdNode;
    }

    public void Add(T value)
    {
        Node node = new Node(value);
        node = head;
    }
    public void PrintValues()
    {
        Console.WriteLine($"Values: {FirstNode.ToString()}, {SecondNode.ToString()}, and {ThirdNode.ToString()}");
    }
}

