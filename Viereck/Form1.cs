using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viereck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Rectangle> rectangles = new List<Rectangle>();
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        Point groesseRechteck = new Point(100, 100);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (rectangles.Count != 0)
            {
                foreach (Rectangle rectangle in rectangles)
                {
                    graphics.FillRectangle(blueBrush, rectangle);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point1 = e.Location;
            while (MouseButtons.Left == Control.MouseButtons)
            {
            }
            Point point2 = //OKasdopaksdopaksdopaksd

            if (e.Location.X == point2.X && e.Location.Y == point2.Y)
            {
                rectangles.Add(new Rectangle(e.Location.X - groesseRechteck.X / 2, e.Location.Y - groesseRechteck.Y / 2, groesseRechteck.X, groesseRechteck.Y));
            }
            else
            {
                rectangles.Add(new Rectangle(e.Location.X,e.Location.Y, 300, 300));
            }
            MessageBox.Show("alte position: " + e.Location.ToString(), "Neue Position: " + point2.ToString());
            Refresh();
        }
        private Point PointToClient(Point point)
        {

        }
    }
}
