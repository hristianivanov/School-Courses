namespace AreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBox1.Text);
            double area = 0;
            if (radioButton1.Checked)
                area = TriangleArea(side);
            else if (radioButton2.Checked)
                area = SquareArea(side);
            else if (radioButton3.Checked)
                area = CircleArea(side);

            MessageBox.Show($"The area is {area:f2}");
            textBox1.Text = string.Empty;
        }
        private static double TriangleArea(double a)
            => Math.Pow(a, 2) * Math.Sqrt(3) / 4;
        private static double SquareArea(double a)
            => Math.Pow(a, 2);
        private static double CircleArea(double a)
            => Math.PI * Math.Pow(a, 2);
    }
}