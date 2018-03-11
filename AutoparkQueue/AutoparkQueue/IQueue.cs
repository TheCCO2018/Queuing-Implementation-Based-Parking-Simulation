using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkQueue
{
    interface IQueue
    {
        void Insert(Node N);
        Node Remove();
        Node Peek();
        Boolean isEmpty();
    }
}
