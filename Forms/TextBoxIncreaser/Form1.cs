namespace TextBoxIncreaser
{
    public partial class Form1 : Form
    {
        private int increaser;
        private const int DEF_WIDTH = 291;
        private const int DEF_HEIGHT = 56;
        public Form1()
        {
            InitializeComponent();
        }
        // def 291, 56
        private void button1_Click(object sender, EventArgs e)
        {

            // up to 360, 56 left maximumm
            if (textBox1.Size.Width + increaser > 360)
                return;
            else
                textBox1.Size = new Size(textBox1.Width+increaser, textBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // up to 707, 56 right maximum 
            if(textBox1.Size.Width + increaser > 707)
                return;
            else
                textBox1.Size = new Size(textBox1.Width+ increaser, textBox1.Height);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // up to 291, 98 up maximum 
            if (textBox1.Size.Height + increaser > 98)
                return;
            else
                textBox1.Size = new Size(textBox1.Width , textBox1.Height + increaser);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // up to 291, 142 down maximum 
            if (textBox1.Size.Height + increaser > 142)
                return;
            else
                textBox1.Size = new Size(textBox1.Width, textBox1.Height + increaser);

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            increaser = 10;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            increaser = 100;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            increaser = 500;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Size = new Size(DEF_WIDTH, DEF_HEIGHT);
        }
    }
}