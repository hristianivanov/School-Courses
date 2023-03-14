namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            text.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        private void ChangePosstion_Click(object sender, EventArgs e)
        {
            text.Location = new Point(546, 387);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            text.Location = new Point(260, 22);
            text.ForeColor = SystemColors.ControlText;
        }
    }
}