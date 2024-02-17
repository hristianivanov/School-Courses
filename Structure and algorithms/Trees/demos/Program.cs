namespace demos
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
            Vertex v9 = new Vertex(9);

            v1.neighbors.AddRange(new List<Vertex>() { v4, v5 });
            v2.neighbors.AddRange(new List<Vertex>() { v5 });
            v3.neighbors.AddRange(new List<Vertex>() { v5, v6 });
            v4.neighbors.AddRange(new List<Vertex>() { v7 });
            v5.neighbors.AddRange(new List<Vertex>() { v7, v8 });
            v6.neighbors.AddRange(new List<Vertex>() { v9 });

            List<Vertex> vertices = new List<Vertex>() { v5, v2, v3, v4, v1, v6, v7, v8, v9 };
            Stack<Vertex> topSortedVertices = new Stack<Vertex>();

            foreach (Vertex vertex in vertices)
            {
                if (vertex.color == "white")
                {
                    TopoSort(vertex);
                }
            }

            while (topSortedVertices.Count > 0)
            {
                Console.WriteLine(topSortedVertices.Pop().data);
            }
            void TopoSort(Vertex current)
            {
                current.color = "gray";
                foreach (var neighbor in current.neighbors)
                {
                    if (neighbor.color == "white")
                    {
                        TopoSort(neighbor);
                    }
                }
                current.color = "black";
                topSortedVertices.Push(current);
            }
        }
    }
}