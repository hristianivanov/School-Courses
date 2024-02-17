namespace demos
{
    using System.Collections.Generic;
  
    public class Vertex
    {
        public int data;
        public List<Vertex> neighbors;
        public string color;
        public Vertex(int data)
        {
            this.data = data;
            this.color = "white";
            this.neighbors = new List<Vertex>();
        }
    }
}
