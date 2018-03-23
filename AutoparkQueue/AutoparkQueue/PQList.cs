using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    class PQList : LinkedList, IPQueue
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
                if(N.Data.exitTime <= front.Data.exitTime)
                {
                    Node temp = front;
                    front = N;
                    N.Next = temp;
                }
                else
                {
                    Node last = front;
                    while (last.Next != null)
                    {
                        if (N.Data.exitTime > last.Data.exitTime && N.Data.exitTime < last.Next.Data.exitTime)
                        {
                            Node temp = last.Next;
                            last.Next = N;
                            N.Next = temp;
                            break;
                        }
                        last = last.Next;
                    }
                    if (last.Next == null)
                    {
                        last.Next = N;
                        rear = N;
                    }
                }             
            }
            count++;
        }
    }
}
