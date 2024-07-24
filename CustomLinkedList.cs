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
        public Node<T> prev;
        public Node<T> next;
    }

    public class CustomStack<T>
    {
        static Node<T> start = null;
        static Node<T> top = null;

        public bool IsEmpty()
        {
            if (start == null)
            {
                return true;
            }
            return false;
        }

        public static T TopElement()
        {
            return top.data;
        }
        public void Pop()
        {
            Node<T> n;
            n = top;
            if (IsEmpty())
                Console.Write("Stack is empty");
            else if (top == start)
            {
                top = null;
                start = null;
                n = null;
            }
            else
            {
                top.prev.next = null;
                top = n.prev;
                n = null;
            }
        }

        public void Push(T d)
        {
            Node<T> n = new Node<T>();
            n.data = d;
            if (IsEmpty())
            {
                n.prev = null;
                n.next = null;
                start = n;
                top = n;
            }
            else
            {
                top.next = n;
                n.next = null;
                n.prev = top;
                top = n;
            }
        }
    }
}
