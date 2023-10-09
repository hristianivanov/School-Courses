namespace Linked_list
{
	public class Node<T>
	{
		public T Element { get; set; }
		public Node<T> Next { get; set; }

		public Node(T element)
		{
			Element = element;
			Next = null;
		}
	}
}
