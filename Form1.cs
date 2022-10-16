using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        int x, y, xVal, yVal;
        Timer tm;
        public Form1()
        {
            InitializeComponent();
            x = 10;
            y = 10;
            xVal = 5;
            yVal = 5;
            tm = new Timer();
            tm.Interval = 80;
            tm.Tick += new EventHandler(display);
            tm.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display(sender, e);
        }

        private void display(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(Brushes.Black, new Rectangle(x, y, 50, 50));
            x += xVal;
            y += yVal;
            pictureBox1.Image = bmp;
            if (x <= 0 || x >= (pictureBox1.Width - 50))
            {
                xVal = xVal * (-1);
            }
            if(y <= 0 || y >= (pictureBox1.Height - 50))
            {
                yVal *= -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(400, 400);
                 
        }
    }
}
