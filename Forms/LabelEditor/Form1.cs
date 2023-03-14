using System.Windows.Forms;

namespace LabelEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Size = new Size(235, 34);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Size = new Size(265, 113);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.None;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currSize = textBox1.Font.Size;
            currSize += 2.0F;
            textBox1.Font = new Font(textBox1.Font.Name, currSize,
textBox1.Font.Style, textBox1.Font.Unit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currSize = textBox1.Font.Size;
            currSize -= 2.0F;
            textBox1.Font = new Font(textBox1.Font.Name, currSize,
textBox1.Font.Style, textBox1.Font.Unit);
        }
    }
}