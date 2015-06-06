using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StackNode
    {
        private int data;
        public StackNode(int data)
        {
            this.data = data;
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
    class StackUsingArray
    {
        StackNode[] ar = new StackNode[20];
        int stackTop = 0;

        public void Push(StackNode node)
        {
            StackNode n = null;
            if(node == null)
            {
                return;
            }
            n = new StackNode(node.Data);
            ar[stackTop] = n;
            stackTop++;
        }

        public StackNode Pop()
        {
            return ar[stackTop];
        }

        public int Count()
        {
            return stackTop;
        }
    }
}
