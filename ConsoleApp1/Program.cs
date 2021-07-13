using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Node 
    {
        public int data;
        public Node next;

        public Node(int data)          
        {
            this.data = data;
        }

    }

    class LinkedList 
    {
        Node head;

        public void Insert(int data)
        {
            Node newNode = new Node(data);

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node n = head;
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = newNode;
            }
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void InsertAtIndex(int index,int data)
        {
           
            
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }

            else if (index == 0)
            {
                InsertAtBeginning(data);
            }
          
            else
            {
                Node n = head;
                for (int i = 0; i < index - 1 && n != null; i++)
                {
                    n = n.next;
                }
                if(n != null)
                {
                    newNode.next = n.next;
                    n.next = newNode;
                }
                else
                {
                    Insert(data);
                }
                
            }
        }

        public void Traverse()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + "->");
                n = n.next;
            }
        } 

        public int DeleteAtBeginning()
        {
            int res = head.data;
            head = head.next;
            return res;
        }
        public int DeleteAtEnd()
        {
            
            Node n = head;
            if(head == null)
            {
                return -1;
            }
            if(head.next == null)
            {
                int res = head.data;
                head = null;
                return res;
        
            }
            else
            {
                while (n.next.next != null)
                {
                    n = n.next;
                }
                int res = n.next.data;
                n.next = null;
                return res;
            }
          
        }
    }

    class Program
        {

            public static void Main(string[] args)
            {
                LinkedList l = new LinkedList();
                l.Insert(3);
                l.Insert(4);
                l.Insert(5);
                l.InsertAtBeginning(7);
                l.InsertAtIndex(14,10);
                Console.WriteLine(l.DeleteAtEnd());
                l.Traverse();

            }
        }


}