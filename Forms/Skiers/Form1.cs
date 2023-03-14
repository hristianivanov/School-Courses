namespace Skiers
{
    public partial class Form1 : Form
    {
        private const double JACKET_PRICE = 120;
        private const double HELMET_PRICE = 75;
        private const double SHOES_PRICE = 299.99;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int skiers = int.Parse(textBox1.Text);
            int jacketCnt = int.Parse(textBox2.Text);
            int helmetCnt = int.Parse(textBox3.Text);
            int shoesCnt = int.Parse(textBox4.Text);

            double sum = GetSumForAllSkiers(skiers, jacketCnt, helmetCnt, shoesCnt);
            MessageBox.Show($"Sum for all skiers: {sum:f2}" +
                $"{Environment.NewLine}After 15% promotion the sum is {sum * 0.85:f2}");

            textBox1.Text = string.Empty; textBox2.Text = string.Empty;
            textBox3.Text = string.Empty; textBox4.Text = string.Empty;
        }

        private static double GetSumForAllSkiers(int skiers, int jacketCnt, int helmetCnt, int shoesCnt)
         => skiers * ((jacketCnt * JACKET_PRICE) + (helmetCnt * HELMET_PRICE) + (shoesCnt * SHOES_PRICE));
    }
}