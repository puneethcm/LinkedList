using System;
namespace LinkedList
{
	public class CustomLinkedList
	{
        public Node head;
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is Inserted into Linked List", newNode.data);
        }
        public void AddFirst(int data)
        {

            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} is inserted into LikedList", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked List is Empty ");
            }
            Console.WriteLine("\nDisplaying Nodes: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

