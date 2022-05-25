using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{

    class DoubleLinekdList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public DoubleLinekdList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public int Count
        { set; get; }

        public void AddFirst(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                tail = node;

            }
            else
            {
                head.Prev = node;
                node = head.Next;
                head = node;

            }

            Count++;
        }
        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            if (head == null)
            {
                head = node;
                tail = node;

            }
            else
            {
                tail.Next = node;
                node.Prev = tail;
                tail = node;

            }
            Count++;
        }
        public void RemoveFirst()
        {
            Node<T> node = head.Next;
            if (head == null && tail == null)
            {
                throw new InvalidOperationException("The List is empty.");

            }
            else
            {

                head.Next = node;
                node.Prev = null;
                head = node;
            }
            Count--;
        }
        public void RemoveLast()
        {
            Node<T> node = tail.Prev;
            if (tail == null && head == null)
            {
                throw new InvalidOperationException("The List is empty");
            }
            else
            {
                node.Next = null;
                tail = node;

            }
            Count--;
        }
       
    }
}
