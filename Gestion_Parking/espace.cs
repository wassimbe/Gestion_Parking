using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Parking
{
    public partial class espace : Form
    {
        public espace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3 p = new form3();
            p.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }
    }
}
