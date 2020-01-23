using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bursa
{
    public partial class Grafic_Profit : Form
    {
        public Grafic_Profit()
        {
            InitializeComponent();
        }

        private void Grafic_Profit_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //GRAF
            Graphics graphics = this.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            pen.Width = 5;
            //OX
            int y1 = this.panel1.Height / 2;
            int x2 = this.panel1.Width - 5;
            graphics.DrawLine(pen, 5, y1, x2, y1);
            //OY
            int y2 = this.panel1.Height - 5;
            graphics.DrawLine(pen, 5, 5, 5, y2);
        }
    }
}
