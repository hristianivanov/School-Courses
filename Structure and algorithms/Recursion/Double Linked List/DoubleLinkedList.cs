namespace Double_Linked_List
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class DoublyLinkedList<T> : IEnumerable<T>
	{
		private class Node
		{
			public Node(T value)
			{
				this.Value = value;
			}
			public T Value { get; set; }
			public Node Next { get; set; }
			public Node Previous { get; set; }


		}

		private Node head;
		private Node tail;

		public int Count { get; private set; }

		public void Add(T item)
		{
			var newNode = new Node(item);
			if (this.head == null)
			{
				this.head = this.tail = newNode;
			}
			else
			{
				newNode.Previous = this.tail;
				this.tail.Next = newNode;
				this.tail = newNode;

			}

			this.Count++;
		}
		public void Reverse()
		{
			Node previous = null;

			tail = head;
			Node current = head;
			while (current != null)
			{

				previous = current.Previous;
				current.Previous = current.Next;
				current.Next = previous;


				current = current.Previous;
			}

			if (previous != null)
			{
				head = previous.Previous;
			}
		}


		public void Traverse()
		{
			this.Traverse(head);
		}


		private void Traverse(Node current)
		{
			if (current == null)
			{
				return;
			}
			Console.WriteLine(current.Value);

			Traverse(current.Next);
		}

		public void TraverseBackWards()
		{
			this.TraverseBackWards(this.tail);
		}
		private void TraverseBackWards(Node current)
		{
			if (current == null)
			{
				return;
			}
			Console.WriteLine(current.Value);

			TraverseBackWards(current.Previous);
		}

		private void RemoveAt<T>(int k, Node current)
		{


			if (k == 0)
			{
				if (current.Next == null && current.Previous == null)
				{
					current = null;
					return;
				}
				if (current.Next == null)
				{
					current.Previous.Next = null;
					this.tail = current.Previous;
					current.Previous = null;
					return;
				}
				if (current.Previous == null)
				{
					current.Next.Previous = null;
					this.head = current.Next;
					current.Next = null;
					return;
				}
				var temp = CopyNode(current);
				current.Previous.Next = temp.Next;
				current.Next.Previous = temp.Previous;
				return;
			}

			this.RemoveAt<T>(k--, current.Next);
		}

		public void RemoveAt<T>(int k)
		{
			this.RemoveAt<T>(k, this.head);
		}

		private Node CopyNode(Node head)
		{
			var node = new Node(head.Value);
			node.Next = head.Next;
			node.Previous = head.Previous;

			return node;
		}

		public IEnumerator<T> GetEnumerator()
		{
			var node = this.head;
			while (node != null)
			{
				yield return node.Value;
				node = node.Next;

			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		=> GetEnumerator();
	}
}
