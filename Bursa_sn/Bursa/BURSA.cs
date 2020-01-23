using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Bursa
{
    public partial class BURSA : Form
    {
        public BURSA()
        {
            InitializeComponent();
        }

        ACTIUNI act = new ACTIUNI();
        Random random = new Random();
        string[] numeActiuni = {"Azomed","Tepra","Raddin","Nelacom","Daleprod"};
        Grafic_Profit graf_prof = new Grafic_Profit();
        Graphics graphics;
        int x_curent, y_curent;
        int last_profit = 0;

        private void BURSA_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            act.deleteActiunileMele();
            act.initActiunileMele();
            this.dataGridView1.DataSource = act.getBursa();
            graphics = graf_prof.panel1.CreateGraphics();
            x_curent = 5;
            y_curent = graf_prof.panel1.Height / 2 - 5;
        }

        private void button_DeschideBursa_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button_InchideBursa_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string fn = Application.StartupPath+@"\rezultate.txt";
            System.IO.File.WriteAllText(fn, act.getProfit().ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reimprospatareDate();
            this.dataGridView1.DataSource = act.getBursa();
        }

        public void reimprospatareDate()
        {
            //coloana 5
            for (int i = 0; i < 5; i++)
            {
                int r = random.Next(-5, 5);
                act.updateCrestere(r, numeActiuni[i]);
            }

            //coloana 4
            act.updateValMomentana();

            //colana 6
            //act.updateValTotalInit();

            //coloana 7
            act.updateValTotalMoment();

            //coloana 8
            act.updateProfitMoment();

            //coloana 9
            act.updateProfitTotal();

            //textboxProfit
            this.textBox_Profit.Text = act.getProfit().ToString();

            //graf profit
            //Graphics graphics = graf_prof.panel1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            pen.Width = 5;
            if (last_profit < act.getProfit())
            {
                graphics.DrawLine(pen, x_curent, y_curent, x_curent + 1, y_curent - 1);
                x_curent++;
                y_curent--;
            }
            else
            {
                graphics.DrawLine(pen, x_curent, y_curent, x_curent + 1, y_curent + 1);
                x_curent++;
                y_curent++;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(this.numericUpDown1.Value);
        }

        private void graficProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graf_prof.Show();
        }

        private void BURSA_Paint(object sender, PaintEventArgs e)
        {
            //GRAF
            Pen pen = new Pen(Color.Blue);
            pen.Width = 5;
            //OX
            int y1 =graf_prof.panel1.Height / 2;
            int x2 =graf_prof.panel1.Width - 5;
            graphics.DrawLine(pen, 5, y1, x2, y1);
            //OY
            int y2 = graf_prof.panel1.Height - 5;
            graphics.DrawLine(pen, 5, 5, 5, y2);
        }
    }
}
