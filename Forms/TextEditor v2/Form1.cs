namespace TextEditor_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            text.Location = new Point(267, 12);
        }

        private void MoveToCenter_Click(object sender, EventArgs e)
        {
            text.Location = new Point(278, 169);
        }

        private void moveUpRight_Click(object sender, EventArgs e)
        {
            text.Location = new Point(546, 12);
        }

        private void changeTextButton_Click(object sender, EventArgs e)
        {
            string[] data = new string[] {
                "Hello Guys!",
                "Hello World!",
                "Bonjour!",
                "Hola!",
                "Zdravstvuyte",
                "Nǐn hǎo",
                "Konnichiwa",
                "Asalaam alaikum",
                "Merhaba",
                "Shalom"
            };
            Random random = new Random();
            text.Text = data[random.Next(data.Length)];
        }
    }
}