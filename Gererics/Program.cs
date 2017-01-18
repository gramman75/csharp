using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gererics
{
    public class GerericList<T> where T: struct 
    {
        private class Node
        {
            private T data;
            public T Data { get; set; }

            private Node next;
            public Node Next { get; set; }

            public Node(T t)
            {
                next = null;
                data = t;
            }
        }

        private Node head;

        public int Count { get; set; }

        public void add(T t)
        {
            Node newNode = new Node(t);
            newNode.Data = t;
            newNode.Next = head;
            head = newNode;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("S", 1);

            Console.WriteLine(dic["S"]);

            GerericList<int> list = new GerericList<int>();

            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);

            foreach(var str in list)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(list.Count);

        }
    }
}
