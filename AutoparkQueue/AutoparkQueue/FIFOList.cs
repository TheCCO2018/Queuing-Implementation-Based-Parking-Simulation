using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    public class FIFOList : LinkedList, IQueue
    {

        public void Insert(Node N)
        {
            if (front == null)
            {
                front = N;
                rear = N;
            }
            else
            {
                Node last = front;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = N;
                rear = N;
            }
            count++;

        }

    }
}
