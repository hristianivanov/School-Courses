namespace BellmanFord_sorting_algorithm
{
	public class Vertex<T>
	{
		public T data;
		public List<Edge<T>> edges;
		public int distance;

        public Vertex(T data)
        {
            this.data = data;
            this.distance = int.MaxValue;
            this.edges = new List<Edge<T>>();
        }
    }
}
