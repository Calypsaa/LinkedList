using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public int getData()
        {
            return data;
        }
        public void setData(int data)
        {
            this.data = data;
        }
    }
}
