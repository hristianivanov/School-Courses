namespace Fractions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> nums = new List<string>();

            for (int i = 0; i < input.Count; i+=2)
            {
                RacionalNumber racionalNumber = new RacionalNumber(input[i], input[i+1] );
                nums.Add(racionalNumber.Nums);
            }

            foreach (var item in nums)
            { 
                Console.Write(item+"; ");
            }
        }
    }
}