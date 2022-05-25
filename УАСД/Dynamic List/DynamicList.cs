using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_List
{
    class DynamicList
    {
        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
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


        // tova
        public void Add(object item)
        {
            Node node = new Node(item);
            if (head==null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            Count++;
        }
        
        // tova
        public int Remove(object item)
        {
            if (head == null || tail == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            int index = -1;
            int i = 0;
            Node current = head;
            Node prevCurrent = null;

            if (Count == 1 && current.Element.Equals(item))
            {
                head = null;
                tail = null;
                index = 0;
                Count = 0;
            }

            else
            {
                while (current != null && !current.Element.Equals(item))
                {
                    prevCurrent = current;
                    current = current.Next;
                    i++;
                }
                if (current.Element.Equals(item))
                {
                    prevCurrent.Next = current.Next;
                    index = i;
                }
            }
            return index;
        }

        public int IndexOf(object item)
        {
            int i = 0;
            Node currentNode = head;
            while (currentNode != null && !currentNode.Element.Equals(item))
            {
                currentNode = currentNode.Next;
                i++;
            }
            if (currentNode == null)
            {
                return -1;
            }
            return i;
        }

        // tova
        public object RemoveAt(int index)
        {

            if (head == null || tail == null)
            {
                throw new InvalidOperationException("The list is empty");
            }

            if (index + 1 >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            else
            {

                Node current = head;
                Node prevCurrent = null;

                int currentIndex = 0;

                while (index!=currentIndex)
                {
                    prevCurrent = current;
                    current = current.Next;

                    currentIndex++;
                }

                prevCurrent.Next = current.Next;

                return current.Element;
                
 
            }   
            
        }

       // tova
       public void Print()
        {
            Node current = head;
            while (current!=null)
            {
                Console.Write($"{current.Element} ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public object this[int index]
        {
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int i = 0;
                Node current = head;
                while (current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }

                current.Element = value;
            }
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int i = 0;
                Node current = head;
                while (current != null && i < index)
                {
                    current = current.Next;
                    i++;
                }
                return current.Element;
                
            }

        }

    }
}
