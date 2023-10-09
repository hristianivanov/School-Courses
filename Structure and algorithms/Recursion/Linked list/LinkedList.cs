namespace Linked_list
{
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
}
