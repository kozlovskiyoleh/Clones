using NUnit.Framework.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T data = default(T), Node<T> next = null)
        {
            this.data = data;
            this.next = next;
        }
    }

    public class CustomStack<T>
    {
        public Node<T> head;

        public CustomStack(Node<T> head = null)
        {
            this.head = head;
        }

        public Node<T> GetHead() => head;

        public void AddToEnd(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
            }
            else
            {
                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node<T>(item);
            }
        }

        public void Pop() => head = head.next;

        public T Peek() => head.data;

        public void Push(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
            }
            else
            {
                Node<T> current = new Node<T>(item, head);
                head = current;
            }
        }
    }
}
