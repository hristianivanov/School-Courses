namespace ColorChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //black
        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        //red
        private void button5_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Red;
        }
        //red
        private void button3_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Red;
        }
        //lime
        private void button2_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Lime;
        }
        //cyan
        private void button1_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.White;
        }
        //clear
        private void button6_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.White;
        }

        private void plate_TextChanged(object sender, EventArgs e)
        {

        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Black;
        }

        private void goldButton_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Gold;
        }

        private void limeButton_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Lime;
        }

        private void cyanButton_Click(object sender, EventArgs e)
        {
            plate.BackColor = Color.Cyan;
        }
    }
}