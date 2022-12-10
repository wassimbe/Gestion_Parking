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
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width>=724)
            {
                timer1.Stop();
                Form1 aa = new Form1();
                aa.Show();
                this.Hide();

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
