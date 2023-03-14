namespace StudentsCounter
{
    public partial class Form1 : Form
    {
        private bool EightA = false;
        private bool EightB = false;
        private bool EightC = false;
        private int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EightA = true;
        }

        private void EightBcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            EightB = true;
        }

        private void EightCcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            EightC = true;
        }

        private void ShowButton1_Click(object sender, EventArgs e)
        {
            if (counter != 0)
                counter = 0;
            if (girlsradioButton1.Checked && boysradioButton2.Checked)
            {
                if (EightA)
                    counter += SumStringNumbers(EightABoysTextBox.Text, EightAGirlsTextBox.Text);
                if (EightB)
                    counter += SumStringNumbers(EightBBoysTextBox.Text, EightBGirlsTextBox.Text);
                if (EightC)
                counter += SumStringNumbers(EightCBoysTextBox.Text, EightCGirlsTextBox.Text);
            }
            else if (girlsradioButton1.Checked)
            {
                if (EightA && EightAGirlsTextBox.Text != "")
                    counter += int.Parse(EightAGirlsTextBox.Text);
                if (EightB && EightBGirlsTextBox.Text != "")
                    counter += int.Parse(EightBGirlsTextBox.Text);
                if (EightC && EightCGirlsTextBox.Text != "")
                    counter += int.Parse(EightCGirlsTextBox.Text);
            }
            else  if(boysradioButton2.Checked)
            {
                if (EightA && EightABoysTextBox.Text != "")
                    counter += int.Parse(EightABoysTextBox.Text);
                if (EightB && EightBBoysTextBox.Text != "")
                    counter += int.Parse(EightBBoysTextBox.Text);
                if (EightC && EightCBoysTextBox.Text != "")
                    counter += int.Parse(EightCBoysTextBox.Text);
            }

            CountLabel.Text = $"Count: {counter}";
        }

        private void girlsradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boysradioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int SumStringNumbers(string a, string b)
        {
            if(a == "" || b == "")
                return 0;
            return int.Parse(a) + int.Parse(b);
        }
    }
}