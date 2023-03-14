namespace FormTest
{
    public partial class Form1 : Form
    {
        private int correctCnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            correctCnt++;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            correctCnt++;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            correctCnt++;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            correctCnt++;
        }

        private int GetGrade()
            => 2 + correctCnt;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetGrade().ToString();
        }
    }
}