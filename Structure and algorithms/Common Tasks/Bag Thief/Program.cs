namespace Bag_Thief
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Item[] items = new Item[]
			{
				new Item()
				{
					Quantity = 25,
					Price = 5
				},
				new Item()
				{
					Quantity = 35,
					Price = 10
				},
				new Item()
				{
					Quantity = 10.5,
					Price = 2
				},
			};
			double bagMaxStorage = double.Parse(Console.ReadLine()!);

			// GOAL : maximum amount of money to collect in the bag

			items = items
				.OrderByDescending(item => item.Price)
				.ToArray();

			decimal sum = 0m;

			for (int i = 0; i < items.Length; i++)
			{
				if (bagMaxStorage == 0)
				{
					break;
				}

				if (items[i].Quantity <= bagMaxStorage)
				{
					sum += items[i].Price * (decimal)items[i].Quantity;
					bagMaxStorage -= items[i].Quantity;
				}
			}

			Console.WriteLine(sum);
		}
	}

	class Item
	{
		public double Quantity { get; set; }

		public decimal Price { get; set; }
	}
}