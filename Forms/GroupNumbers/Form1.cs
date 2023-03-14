namespace GroupNumbers
{
    using System.Text;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nums = textBox1.Text
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var firstGroup = nums.Where(x => x % 10 == 2 || x % 10 == 4).ToList();
            var secondGroup = nums.Where(x => x % 10 == 5 || x % 10 == 7).ToList();
            var thirdGroup = nums.Where(x => SumOfDigits(x) % 10 == 3).ToList();
            var fourthGroup = nums.Where(x => SumOfDigits(x) % 10 == 6).ToList();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(string.Join(",", firstGroup))
                .AppendLine()
                .AppendLine(string.Join(",", secondGroup))
                .AppendLine()
                .AppendLine(string.Join(",", thirdGroup))
                .AppendLine()
                .AppendLine(string.Join(",", fourthGroup));

            richTextBox1.Text = stringBuilder.ToString();
        }

        private static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            return sum;
        }
    }
}