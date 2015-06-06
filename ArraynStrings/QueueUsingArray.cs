using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Node
    {
        private int data;

        public Node(int value)
        {
            data = value;
        }
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
    }

    class QueueUsingArray
    {
        Node[] queueData = new Node[10];
        public int queueFront = 0;
        public int queueBack = 0;

        public void Enqueue(Node n)
        {
            if(n == null)
            {
                return;
            }
            queueData[queueBack] = n;
            queueBack++;
        }

        public Node Dequeue()
        {
            Node n = null;
            if(queueBack > queueFront)
            {
                n = queueData[queueFront];
                queueFront++;
            }
            return n;
        }

        public int Count()
        {
            return queueBack - queueFront;
        }
    }
}
