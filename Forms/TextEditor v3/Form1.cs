namespace TextEditor_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeTextButton_Click(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            label1.Text = richTextBox1.Text;
            richTextBox1.Text = string.Empty;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            richTextBox1.Text = string.Empty;
        }

        private void typer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}