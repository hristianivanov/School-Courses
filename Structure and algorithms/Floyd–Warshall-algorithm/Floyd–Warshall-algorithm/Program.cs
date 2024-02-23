namespace Floyd_Warshall_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertex<int> v1 = new Vertex<int>(0);
            Vertex<int> v2 = new Vertex<int>(1);
            Vertex<int> v3 = new Vertex<int>(2);
            Vertex<int> v4 = new Vertex<int>(3);
            Vertex<int> v5 = new Vertex<int>(4);
            Vertex<int> v6 = new Vertex<int>(5);
            Vertex<int> v7 = new Vertex<int>(6);

            v1.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v2, 4), Tuple.Create(v5, 2) });
            v2.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v7, 3) });
            v3.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v4, 2), Tuple.Create(v6, 2) });
            v4.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v6, -4) });
            v5.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v3, -2) });
            v7.edges.AddRange(new List<Tuple<Vertex<int>, int>>() { Tuple.Create(v5, -1), Tuple.Create(v3, 1), Tuple.Create(v4, 7) });

            List<Vertex<int>> vertices = new List<Vertex<int>>() { v1, v2, v3, v4, v5, v6, v7 };

            int[,] distances = new int[vertices.Count, vertices.Count];

            for (int i = 0; i < vertices.Count; i++)
            {
                for (int j = 0; j < vertices.Count; j++)
                {
                    if (i == j)
                    {
                        distances[i, j] = 0;
                    }
                    else
                    {
                        distances[i, j] = int.MaxValue;
                    }
                }
            }

            foreach (Vertex<int> from in vertices)
            {
                foreach (Tuple<Vertex<int>, int> edge in from.edges)
                {
                    distances[from.data, edge.Item1.data] = edge.Item2;
                }
            }

            foreach (Vertex<int> vertex in vertices)
            {
                for (int i = 0; i < distances.GetLength(0); i++)
                {
                    for (int j = 0; j < distances.GetLength(1); j++)
                    {
                        if (distances[i, vertex.data] + distances[vertex.data, j] < distances[i, j]
                            && distances[i, vertex.data] != int.MaxValue
                            && distances[vertex.data, j] != int.MaxValue)
                        {
                            distances[i, j] = distances[i, vertex.data] + distances[vertex.data, j];
                        }
                    }
                }
            }

            for (int i = 0; i < distances.GetLength(0); i++)
            {
                for (int j = 0; j < distances.GetLength(1); j++)
                {
                    Console.Write((distances[i, j] != int.MaxValue ? distances[i, j].ToString() : "∞") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}