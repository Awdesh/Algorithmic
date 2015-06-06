using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private LinkedListNode head;

        public void AddFirst(int data)
        {
            LinkedListNode current = new LinkedListNode();
            current.setData(data);
            current.setNext(head);
            head = current;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(int data)
        {
            if (head == null)
            {
                head = new LinkedListNode();
                head.setData(data);
                head.setNext(null);
            }

            LinkedListNode toAdd = new LinkedListNode();
            toAdd = head;
            while (toAdd.getNext() != null)
            {
                toAdd = toAdd.getNext();
            }
            toAdd.setData(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public void DeleteNode(int data)
        {
            if (head == null)
            {
                return;
            }

            LinkedListNode prev;
            LinkedListNode ll = new LinkedListNode();
            ll = head;
            prev = new LinkedListNode();

            while (ll != null)
            {
                prev = ll;
                ll = ll.getNext();
                if (ll.getData() == data)
                {
                    prev.setNext(ll.getNext());
                    break;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedListNode node1 = new LinkedListNode();
            LinkedListNode node2 = new LinkedListNode();
            LinkedListNode node3 = new LinkedListNode();

            node1.setData(20);
            node1.setNext(node2);
            node2.setData(10);
            node2.setNext(node3);
            node3.setData(10);
            node3.setNext(null);

            CenterLinkedList center = new CenterLinkedList();
            LinkedListNode n = center.FindCenter(node1);
            Console.WriteLine("Center of the list is-: {0}", n.getData());

            DeleteItemFromLinkedList d = new DeleteItemFromLinkedList();
            LinkedListNode node = d.DeleteNode(node1, 10);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class LinkedListNode
    {
        private LinkedListNode next;
        private int data;

        public LinkedListNode()
        {

        }

        public LinkedListNode(int data)
        {
            this.data = data;
        }

        public int getData()
        {
            return this.data;
        }


        public void setData(int value)
        {
            data = value;
        }

        public void setNext(LinkedListNode value)
        {
            next = value;
        }

        public LinkedListNode getNext()
        {
            return this.next;
        }
    }
}
