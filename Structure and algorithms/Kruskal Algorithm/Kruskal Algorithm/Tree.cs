namespace Kruskal_Algorithm
{
	public class Tree
	{
		public int vertex;
		public int parent;
		public int height;

		public Tree(int vertex)
		{
			this.vertex = vertex;
			this.parent = vertex;
			this.height = 0;
		}
	}
}
