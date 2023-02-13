using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Linked List");
        CustomLinkedList linkedlist = new CustomLinkedList();
        linkedlist.Add(56);
        linkedlist.Add(70);
        linkedlist.insertAtMid(30);
        linkedlist.Display();
        Console.ReadLine();
    }
}