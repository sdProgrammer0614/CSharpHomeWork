using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = tail = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            } else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for(Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intList.Add(x);
            }

            // 打印链表元素
            intList.ForEach(m => Console.WriteLine(m));

            // 求最大值、最小值
            int max = intList.Head.Data;
            int min = intList.Head.Data;
            intList.ForEach(m => max = max < m ? m : max);
            intList.ForEach(m => min = min > m ? m : min);
            Console.WriteLine($"Max = {max}, Min = {min}");

            // 求和
            int sum = 0;
            intList.ForEach(m => sum += m);
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
