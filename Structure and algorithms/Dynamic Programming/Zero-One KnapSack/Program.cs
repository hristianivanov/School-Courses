namespace Knapsack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var items = new List<Item>()
			{
				new Item(10,120),
				new Item(20, 100),
				new Item(30,500),
			};

			int W = 50; // Knapsack capacity
			int n = items.Count;

			var matrix = new int[n + 1, W + 1];

			for (int j = 0; j <= W; j++)
				matrix[0, j] = 0;

			for (int i = 1; i <= n; i++)
				matrix[i, 0] = 0;

			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= W; j++)
				{
					if (items[i - 1].Weight > j)
						matrix[i, j] = matrix[i - 1, j];
					else
						matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i - 1, j - items[i - 1].Weight] + items[i - 1].Value);
				}
			}

			Console.WriteLine("Maximum value in the knapsack: " + matrix[n, W]);
		}
	}

	public class Item
	{
		public int Value { get; set; }
		public int Weight { get; set; }

		public Item(int weight, int value)
		{
			Weight = weight;
			Value = value;
		}
	}
}
