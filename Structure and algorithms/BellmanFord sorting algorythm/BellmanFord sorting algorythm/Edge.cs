namespace BellmanFord_sorting_algorithm
{
	public class Edge<T>
	{
		public Vertex<T> from;
		public  Vertex<T> to;
		public int weight;

        public Edge(Vertex<T> from, Vertex<T> to, int weight)
        {
            this.from = from;
			this.to = to;
			this.weight = weight;
        }
    }
}
