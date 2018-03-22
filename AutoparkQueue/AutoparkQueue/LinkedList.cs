using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    public abstract class LinkedList
    {
        public Node front;

        public Node rear;
        public int count { get; set; }

        public Node Remove()
        {
            if (count == 0)
            {
                return null;
            }
            else
            {
                Node temp = front;
                front = temp.Next;
                count--;
                return temp;
            }
        }

        public Node Peek()
        {
            return front;
        }

        public bool isEmpty()
        {
            if (count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
