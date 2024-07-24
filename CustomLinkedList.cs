using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clones
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    public class CustomStack
    {
        LinkedListNode top;

        public CustomStack()
        {
            top = null;

        }
        public LinkedListNode GetNode(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            return node;
        }
        public void Push(int data)
        {
            LinkedListNode newNode = GetNode(data);
            if (top == null)
            {
                top = newNode;
                return;
            }
            newNode.next = top;
            top = newNode;

        }
        public int Peek()
        {
            if (top != null)
            {
                return top.data;
            }
            return -1;
        }
        public int Pop()
        {
            int peek = -1;
            if (top != null)
            {
                peek = top.data;
                top = top.next;
            }
            return peek;
        }
    }
}
