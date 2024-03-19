namespace Prim_Algogorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vertex v1 = new Vertex(1);
			Vertex v2 = new Vertex(2);
			Vertex v3 = new Vertex(3);
			Vertex v4 = new Vertex(4);
			Vertex v5 = new Vertex(5);
			Vertex v6 = new Vertex(6);
			Vertex v7 = new Vertex(7);
			Vertex v8 = new Vertex(8);

			List<Vertex> vertices = new List<Vertex>() { v1, v2, v3, v4, v5, v6, v7, v8 };

			v1.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v2, 5), Tuple.Create(v3, 2), Tuple.Create(v8, 1) });
			v2.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v1, 5), Tuple.Create(v4, 2), Tuple.Create(v3, 6) });
			v3.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v2, 6), Tuple.Create(v1, 2), Tuple.Create(v5, 3), Tuple.Create(v6, 2), Tuple.Create(v8, 1) });
			v4.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v2, 2), Tuple.Create(v5, 3), Tuple.Create(v7, 100) });
			v5.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v3, 3), Tuple.Create(v4, 3), Tuple.Create(v6, 1) });
			v6.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v5, 1), Tuple.Create(v3, 2) });
			v7.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v4, 100) });
			v8.Neighbours.AddRange(new List<Tuple<Vertex, int>>() { Tuple.Create(v1, 1), Tuple.Create(v3, 1) });


			v1.State = "tree";
			v1.lightestEdge = Tuple.Create(v1, 0);
			foreach (Tuple<Vertex, int> edge in v1.Neighbours)
			{
				edge.Item1.State = "fringe";
				edge.Item1.lightestEdge = Tuple.Create(v1, edge.Item2);
			}

			while (vertices.Any(v => v.State != "tree"))
			{
				Vertex vertexWithLightestEdge = vertices.Where(v => v.State == "fringe").MinBy(e => e.lightestEdge.Item2);
				vertexWithLightestEdge.State = "tree";
				foreach (Tuple<Vertex, int> edge in vertexWithLightestEdge.Neighbours.Where(e => e.Item1.State != "tree"))
				{
					edge.Item1.State = "fringe";
					edge.Item1.lightestEdge = edge.Item2 < edge.Item1.lightestEdge.Item2 ? Tuple.Create(vertexWithLightestEdge, edge.Item2) : edge.Item1.lightestEdge;
				}
			}

			foreach (var vertex in vertices)
			{
				Console.WriteLine($"v{vertex.Value} - {vertex.lightestEdge.Item1.Value} with weight {vertex.lightestEdge.Item2}");
			}
		}
		public class Vertex
		{
			public int Value { get; set; }
			public List<Tuple<Vertex, int>> Neighbours { get; set; }
			public string State { get; set; }
			public Tuple<Vertex, int> lightestEdge { get; set; }

			public Vertex(int val)
			{
				Value = val;
				this.Neighbours = new List<Tuple<Vertex, int>>();
				State = "unknown";
				this.lightestEdge = Tuple.Create<Vertex, int>(null, int.MaxValue);
			}
		}
	}
}
