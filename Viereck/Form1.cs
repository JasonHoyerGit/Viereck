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

        Rectangle rectangle;
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (rectangle != null)
            {
                graphics.FillRectangle(blueBrush, rectangle);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point1 = e.Location;
            rectangle = new Rectangle(point1.X, point1.Y, 100, 100);

            Refresh();
        }
    }
}
