namespace BellmanFord_sorting_algorithm
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vertex<int> v1 = new Vertex<int>(1);
			Vertex<int> v2 = new Vertex<int>(2);
			Vertex<int> v3 = new Vertex<int>(3);
			Vertex<int> v4 = new Vertex<int>(4);
			Vertex<int> v5 = new Vertex<int>(5);
			Vertex<int> v6 = new Vertex<int>(6);
			Vertex<int> v7 = new Vertex<int>(7);
			Vertex<int> v8 = new Vertex<int>(8);
			Vertex<int> v9 = new Vertex<int>(9);
			Vertex<int> v10 = new Vertex<int>(10);
			Vertex<int> v11 = new Vertex<int>(11);

			v1.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v1, v6, 100),
				new Edge<int>(v1, v3, 5),
			});
			v2.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v2, v11, 15),
				new Edge<int>(v2, v10, -3),
				new Edge<int>(v2, v3, 3),
			});
			v3.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v3, v5, -10),
			});
			v4.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v4, v8, 10),
				new Edge<int>(v4, v2, 5),
			});
			v5.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v5, v4, 5),
				new Edge<int>(v5, v7, 5),
			});
			v7.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v7, v9, 10),
			});
			v9.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v9, v8, -2),
			});
			v10.edges.AddRange(new List<Edge<int>>()
			{
				new Edge<int>(v10, v11, 5),
			});


			var vertices = new List<Vertex<int>>() { v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11 };

			var edges = new List<Edge<int>>();
			vertices.ForEach(vertex => edges.AddRange(vertex.edges));

			v1.distance = 0;

			for (int i = 0; i < vertices.Count; i++)
			{
				bool noUpdate = false;
				foreach (Edge<int> edge in edges)
				{
					if (edge.from.distance + edge.weight < edge.to.distance
					    && edge.from.distance != int.MaxValue)
					{
						edge.to.distance = edge.from.distance + edge.weight;
						noUpdate = true;
					}
				}

				if (!noUpdate)
				{
                    Console.WriteLine("Breaking in the " + i + "th iteration!");
                    break;
				}
			}


			foreach (Edge<int> edge in edges)
			{
				if (edge.from.distance + edge.weight < edge.to.distance
				    && edge.from.distance != int.MaxValue)
				{
                    Console.WriteLine("There is a negative cycle in the graph! " +
                                      "Aborting!");
                    return;
				}
			}

			foreach (var vertex in vertices)
			{
                Console.WriteLine(vertex.distance);
            }
		}
	}
}