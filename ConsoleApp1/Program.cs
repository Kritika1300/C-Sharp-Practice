using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Node
    {
        public int value;
        public string key;
        public Node next;
        public Node(string key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
    class HashMap
    {
        public Node head;
        public Dictionary<string, int> dict = new Dictionary<string, int>();
        public void Insert(string key, int value)
        {
            Node newNode = new Node(key, value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = newNode;
            }
        }

        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.key + " " + n.value);
                n = n.next;
            }
        }
    }
    class HelloWorld
    {
        static void Main()
        {
            HashMap hmap = new HashMap();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (!hmap.dict.ContainsKey(input[0]))
                {
                    hmap.Insert(input[0], Convert.ToInt32(input[1]));
                    hmap.dict.Add(input[0], Convert.ToInt32(input[1]));
                }
            }
            hmap.PrintList();
        }
    }


}