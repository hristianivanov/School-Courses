namespace Linked_list
{
	using System.Collections;
	using System.Text;

	public class LinkedList<T>
	{
		private Node<T> head;

		public Node<T> Head { get => head; set => head = value; }
		public int Count { get; set; }

		public LinkedList()
		{
			head = null;
			Count = 0;
		}

		public void AddFirst(T item)
		{
			Node<T> node = new Node<T>(item);

			if (head == null)
				head = node;

			else
			{
				node.Next = head;
				head = node;
			}

			Count++;
		}

		public void AddLast(T item)
		{
			Node<T> node = new Node<T>(item);

			if (head == null)
				head = node;

			else
			{
				Node<T> current = head;

				while (current.Next != null)
				{
					current = current.Next;
				}

				current.Next = node;
			}

			Count++;
		}

		public void RemoveLast()
		{
			if (head == null || head.Next == null)
				head = null;

			else
			{
				Node<T> current = head;

				while (current.Next.Next != null)
				{
					current = current.Next;
				}

				current.Next = null;
			}

			Count--;
		}

		public void RemoveFirst()
		{
			if (head != null)
			{
				head = head.Next;
				Count--;
			}
		}
	}

	public class LinkedList2<T> : IEnumerable<T>
	{
		private class Node<T>
		{
			public T Element { get; set; }
			public Node<T> Next { get; set; }

			public Node(T element, Node<T> next)
			{
				Element = element;
				Next = next;
			}

			public Node(T element)
				: this(element, null)
			{

			}
		}

		private Node<T> head;

		public int Count { get; private set; }

		public void Add(T element)
		{
			var node = new Node<T>(element);
			if (this.head == null)
			{
				this.head = node;
			}
			else
			{
				this.AddNode(head, node);
			}
		}

		private void AddNode(Node<T> head, Node<T> node)
		{
			if (head.Next != null)
			{
				this.AddNode(head.Next, node);
			}
			else
			{
				head.Next = node;
			}
		}

		public void RemoveAt(int index)
		{
			this.RemoveAt(head, index);
		}

		private void RemoveAt(Node<T> node, int index)
		{
			if (index == 2)
			{
				node.Next = node.Next.Next;
				return;
			}
			else
			{
				this.RemoveAt(node.Next, index -= 1);
			}
		}

		public string GetElements()
		{
			StringBuilder sb = new StringBuilder();

			GetElements(head, sb);

			return sb.ToString().TrimEnd();
		}

		private void GetElements(Node<T> head, StringBuilder sb)
		{
			if (head != null)
			{
				sb.Append($"{head.Element} ");
				GetElements(head.Next, sb);
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			var node = this.head;
			while (node != null)
			{
				yield return node.Element;
				node = node.Next;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
			=> this.GetEnumerator();
	}
}
