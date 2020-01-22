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
        private void BURSA_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            act.deleteActiunileMele();
            act.initActiunileMele();
            this.dataGridView1.DataSource = act.getBursaInitiala();
        }

        private void button_DeschideBursa_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button_InchideBursa_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reimprospatareDate();
        }

        public void reimprospatareDate()
        {

        }

    }
}
