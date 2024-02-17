namespace KahnSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Vertex
    {
        public int data;
        public List<Vertex> neighbors;
        public int inDegree;
        public Vertex(int data)
        {
            this.data = data;
            this.neighbors = new List<Vertex>();
            this.inDegree = 0;
        }
    }
}
