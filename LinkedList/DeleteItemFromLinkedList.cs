using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DeleteItemFromLinkedList
    {
        public LinkedListNode DeleteNode(LinkedListNode node, int value)
        {
            if(node == null)
            {
                return node;
            }
            if(node.getData() == value)
            {
                node = node.getNext();
            }
            LinkedListNode current;
            LinkedListNode prev = new LinkedListNode();
            current = node;

            while(current != null)
            {
                if(current.getData() == value)
                {
                    prev.setNext(current.getNext());
                }
                else
                {
                    prev = current;
                }
                current = current.getNext();
            }
            prev.setNext(null);
            return prev;
        }
    }


}
