using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    public class Node
    {
        public Car Data { get; set; }
        public Node Next { get; set; }

        public Node(Car Data, Node Next)
        {
            this.Data = Data;
            this.Next = Next;
        }
    }
}
