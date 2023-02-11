using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Linked List");
        CustomLinkedList linkedlist = new CustomLinkedList();
        linkedlist.AddFirst(70);
        linkedlist.AddFirst(30);
        linkedlist.AddFirst(56);
        linkedlist.Display();
        Console.ReadLine();
    }
}