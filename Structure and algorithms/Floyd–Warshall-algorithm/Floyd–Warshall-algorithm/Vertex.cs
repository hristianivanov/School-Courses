namespace Floyd_Warshall_algorithm
{
    public class Vertex<T>
    {
        public T data;
        public List<Tuple<Vertex<int>, int>> edges;
        public Vertex(T data)
        {
            this.data = data;
            this.edges = new List<Tuple<Vertex<int>, int>>();
        }
    }
}
