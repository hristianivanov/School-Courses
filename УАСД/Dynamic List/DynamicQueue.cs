using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_List
{
    class DynamicQueue
    {
        private Node head;
        private Node tail;
        private int count;

        public DynamicQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        public void Enqueue(object item)
        {
            Node node = new Node(item);
            if (tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
            Count++;
       
        }

        public void Dequeue()
        {
            if (head == null )
            {
                throw new InvalidOperationException("Queue is empty");
            }
           
            if (Count == 1 )
            {
                head = null;
                tail = null;
            }

            else
            {
                head = head.Next;
            }

            Count--;
        }
        

    }
}
