using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ISBST
    {
        public bool VerifyTreeIsBinary(Node root)
        {
            if( root == null )
            {
                return false;
            }
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            Node temp;
            while(q.Count > 0 )
            {
                temp = q.Dequeue();
                if(temp != null && temp > temp.getLeft() && temp < temp.getRight())
                {
                    q.Enqueue(temp.getLeft());
                    q.Enqueue(temp.geRight());
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
