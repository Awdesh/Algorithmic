using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CenterLinkedList
    {
        public LinkedListNode FindCenter(LinkedListNode node)
        {
            LinkedListNode n = null;
            n = node;
            LinkedListNode slow = node;
            LinkedListNode fast = node;
            while(node.getNext()!= null)
            {
                slow = node;
                node = node.getNext();
                fast = node.getNext();
            }
            return slow;
        }

        /// <summary>
        /// http://www.geeksforgeeks.org/nth-node-from-the-end-of-a-linked-list/
        /// </summary>
        /// <param name="node"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public LinkedListNode FindMthNodeFromEnd(LinkedListNode head, int n)
        {
            LinkedListNode slow = head;
            LinkedListNode fast = head;
            int count = 1;
            while(count < n)
            {
                if(fast == null)
                {
                    // n is greater than length of linked list.
                    return null;
                }
                fast = fast.getNext();
                count++;
            }

            while(fast != null)
            {
                fast = fast.getNext();
                slow = slow.getNext();
            }

            return slow;
        }
    }
}
