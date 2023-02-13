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
        public void AddFirst(int data)
        {

            Node node = new Node(data);
            node.next = this.head;
            this.head = node;
            Console.WriteLine("{0} is inserted into LikedList", node.data);
        }
        public void insertAtMid(int data)
        {
            // if list is empty 
            if (head == null)
                head = new Node(data);
            else
            {
                // get a new node 
                Node newNode = new Node(data);

                Node temp = head;
                int len = 0;

                // calculate length of the linked list 
                //, i.e, the number of nodes 
                while (temp != null)
                {
                    len++;
                    temp = temp.next;
                }
                // 'count' the number of nodes after which 
                // the new node is to be inserted 
                int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
                temp = head;

                // 'ptr' points to the node after which 
                // the new node is to be inserted 
                while (count-- > 1)
                    temp = temp.next;

                // insert the 'newNode' and adjust 
                // the required links 
                newNode.next = temp.next;
                temp.next = newNode;
            }
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

