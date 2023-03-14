using System.Reflection;

namespace FaienceCalculator
{
    public partial class Form1 : Form
    {
        private double bathroomWidth = 0;
        private double bathroomHeight = 0;
        private double bathroomLength = 0;
        private double doorWidth = 0;
        private double doorHeight = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out bathroomWidth);
            double.TryParse(textBox2.Text, out bathroomLength);
            double.TryParse(textBox3.Text, out bathroomHeight);
            double.TryParse(textBox4.Text, out doorWidth);
            double.TryParse(textBox5.Text, out doorHeight);
            // example tiles with 1 square foot and + additional 10-15 tiles for waste
            label9.Text += $" {GetBathroomSurface() + 15}";
        }
        private double GetDoorSurface(double width, double height)
            => width * height;
        private double GetFloorSurface(double length, double width)
            => length * width;
        private double GetWallSurface(double length, double height, double width)
            => (length * height * 2) + (width * height * 2);
        private double GetBathroomSurface()
            => (GetFloorSurface(bathroomLength,bathroomWidth) + GetWallSurface(bathroomLength,bathroomHeight,bathroomWidth))
            - GetDoorSurface(doorWidth,doorHeight);

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label9.Text = "Need tiles count :";
        }
    }
}