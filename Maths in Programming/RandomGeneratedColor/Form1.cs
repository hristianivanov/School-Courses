namespace RandomGeneratedColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int grassHeight = 100;

            Brush brush = new SolidBrush(Color.Green);
            var grass = new Rectangle(0, ActiveForm.Height - grassHeight, ActiveForm.Width, grassHeight);

            g.FillRectangle(brush, grass);

            int houseHeight = 100;
            brush = new SolidBrush(Color.Gray);
            //var house = new Rectangle()
        }

        private static void DrawTriangle(int x1, int y1, int size, Graphics g, Pen pen)
        {
            int x2 = x1 + size;
            int y2 = y1;

            int x3 = (x1 + x2) / 2;
            int y3 = y1 - size;

            var a = new Point(x1, y1);
            var b = new Point(x2, y2); 
            var c = new Point(x3, y3);

            g.DrawLine(pen, a, b);
            g.DrawLine(pen, b, c);
            g.DrawLine(pen, c, a);
        }

        private static Color GenerateRandomColor()
        {
            Random r = new Random();



            return Color.FromArgb(r.Next(256) % 256, r.Next(256) % 256, r.Next(256) % 256);
        }
    }
}