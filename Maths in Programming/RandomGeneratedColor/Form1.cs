using System.Drawing;
using System.Security.Policy;

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

            int cnt = 40;
            int size = 200;

            int x1 = 100;
            int y1 = 200;

            var pen = new Pen(Color.Black);

            for (int i = 0; i < cnt; i++)
            {
                pen.Color = GenerateRandomColor();

                x1 += size;

                DrawTriangle(x1,y1,size,g,pen);
            }
        }

        private static Color GenerateRandomColor()
        {
            Random r = new Random();

            return Color.FromArgb(r.Next(256) % 256, r.Next(256) % 256, r.Next(256) % 256);
        }
        private static void DrawTriangle(int x1,int y1,int size, Graphics g, Pen pen)
        {
            int x2 = GetX2(x1, size);
            int y2 = GetY2(y1);

            int x3 = GetX3(x1, x2);
            int y3 = GetY3(y1, size);

            var a = new Point(x1, y1);
            var b = new Point(x2, y2);
            var c = new Point(x3, y3);

            g.DrawLine(pen, a, b);
            g.DrawLine(pen, b, c);
            g.DrawLine(pen, c, a);
        }
        private static int GetY2(int y1)
        {
            int y2;
            y2 = y1;
            return y2;
        }
        private static int GetX2(int x1, int size)
        => x1 + size;
        private static int GetX3(int x1, int x2)
        => (x1 + x2) / 2;
        private static int GetY3(int value, int size)
        => (int)(value - (Math.Sqrt(3) / 2) * size);
    }
}