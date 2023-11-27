namespace House_painter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = 3;

			var red = new int[] { 2, 5, 8 };
			var green = new int[] { 1, 2, 6 };
			var blue = new int[] { 6, 1, 3 };

			var rHouse = new int[red.Length];
			var gHouse = new int[green.Length];
			var bHouse = new int[blue.Length];

			rHouse[0] = red[0];
			gHouse[0] = green[0];
			bHouse[0] = blue[0];

			for (int i = 1; i < n; i++)
			{
				rHouse[i] = Math.Min(gHouse[i - 1], bHouse[i - 1]) + red[i];
				gHouse[i] = Math.Min(rHouse[i - 1], bHouse[i - 1]) + green[i];
				bHouse[i] = Math.Min(gHouse[i - 1], rHouse[i - 1]) + blue[i];
			}

			var optPr = Math.Min(rHouse[rHouse.Length - 1], Math.Min(bHouse[bHouse.Length - 1], gHouse[gHouse.Length - 1]));

			Console.WriteLine(optPr);
}
	}
}