using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Linked List");
        CustomLinkedList linkedlist = new CustomLinkedList();
        linkedlist.Append(56);
        linkedlist.Append(30);
        linkedlist.Append(70);
        linkedlist.Display();
        Console.ReadLine();
    }
}