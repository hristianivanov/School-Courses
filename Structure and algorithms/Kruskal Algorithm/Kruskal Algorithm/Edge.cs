namespace Kruskal_Algorithm
{
	public class Edge
	{
		public Vertex from;
		public Vertex to;
		public int weight;

		public Edge(Vertex from, Vertex to, int weight)
		{
			this.from = from;
			this.to = to;
			this.weight = weight;
		}
	}
}
