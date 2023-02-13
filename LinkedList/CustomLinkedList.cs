using System;
namespace LinkedList
{
	public class CustomLinkedList
	{
        public Node head;
        public void Add(int data)
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
        public void RemoveLast()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("its empty please add nodes");
            if (temp.next == null)
            {
                int data = temp.data;
                temp = null;
                head = temp;
                Console.WriteLine("{0} Node is deleted", data);
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

            }
            int lastDeleteNode = temp.next.data;
            temp.next = null;
            Console.WriteLine("{0} node is deleted ", lastDeleteNode);
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

