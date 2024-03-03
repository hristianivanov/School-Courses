namespace S._Rao_Kosaraju_Algorithm
{
	public class Vertex
	{
		public List<Vertex> neighbors;
		public string color;
		public int data;

		public Vertex(int data)
		{
			this.data = data;
			color = "white";
			neighbors = new List<Vertex>();
		}
	}
}
