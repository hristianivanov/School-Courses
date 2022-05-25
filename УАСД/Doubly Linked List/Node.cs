using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
   
        class Node<T>
        {
            private T element;
            private Node<T> next;
            private Node<T> prev;

            public T Element
            { private set; get; }
            public Node<T> Next
            { set; get; }
            public Node<T> Prev
            { set; get; }

            public Node(T _element)
            {
                Element = _element;
                next = null;
                prev = null;
            }

        
    }
}
