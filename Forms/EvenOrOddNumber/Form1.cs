using System.Security.Cryptography.Xml;

namespace EvenOrOddNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(label2.Text))
                label2.Text = "Please type your number!";
            else if (int.TryParse(richTextBox1.Text, out int number))
            {
                if (IsOdd(number))
                    label2.Text = "Odd";
                else
                    label2.Text = "Even";
            }
            else
                label2.Text = "Type number not text!";
        }

        private bool IsOdd(int number) 
            => number % 2 == 0;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}