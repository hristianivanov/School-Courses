using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_List
{
    class Node
    {
        private object element;
        private Node next;

        public object Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node(object _element)
        {
            Element = _element;
            Next = null;
        }

        public Node (object _element,Node prevNode)
        {
            Element = _element;
            prevNode.next = this;
        }
    }
}
