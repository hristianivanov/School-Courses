using System.Text;

namespace EasterEggs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = int.Parse(textBox1.Text);
            string[] info = richTextBox1.Text
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> kvp = new Dictionary<string, int>();
            foreach (string color in info)
            {
                if (kvp.ContainsKey(color))
                    kvp[color]++;
                else
                    kvp.Add(color, 1);
            }

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in kvp)
            {
                stringBuilder.AppendLine($"{item.Key} eggs: {item.Value}");
            }
            kvp = kvp.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
            stringBuilder.AppendLine($"Max eggs: {kvp.First().Value} -> {kvp.First().Key}");

            MessageBox.Show( stringBuilder.ToString() );
        }
    }
}