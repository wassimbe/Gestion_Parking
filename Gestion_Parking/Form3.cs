using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Parking
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
            ajouter.Enabled = false;
            supprimer.Enabled = false;
            modifier.Enabled = false;
        }

        private void tf_place_TextChanged(object sender, EventArgs e)
        {
            if (tf_place.Text != "")
            {
                exist1();
                try
                {

                    Database.connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Database.connection.Close();
                    return;
                }
                string query = "select * from places where place=@place";
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@place", string.Format(tf_place.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    tf_place.Text = da.GetValue(0).ToString();
                    tf_etat.Text = da.GetValue(1).ToString();

                }
               

            }
            else
            {
                ajouter.Enabled = false;
                supprimer.Enabled = false;
                modifier.Enabled = false;
                tf_place.Text = null;
                tf_etat.Text = null;
            }
            Database.connection.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            espace s = new espace();
            s.Show();
            this.Hide();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if(tf_etat.Text != "")
            {
                try
                {
                    Database.connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    Database.connection.Close();
                    return;
                }
                SqlCommand cmd = new SqlCommand("insert into places values (@place,@etat)", Database.connection);
                cmd.Parameters.AddWithValue("@place", tf_place.Text);
                cmd.Parameters.AddWithValue("@etat", tf_etat.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert successfully");
                Show();
                Database.connection.Close();
                show();
            }
            else
            {
                MessageBox.Show("entrer l'etat");
            }

          
           
        }
        void show()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from places", Database.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            t_places.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = t_places.Rows.Add();
                t_places.Rows[n].Cells[0].Value = dr[0].ToString();
                t_places.Rows[n].Cells[1].Value = dr[1].ToString();
            }
            Database.connection.Close();
        }
        //lier les textbox par le tablaeu
        private void t_places_MouseClick(object sender, MouseEventArgs e)
        {
           
            tf_place.Text = t_places.SelectedRows[0].Cells[0].Value.ToString();
            tf_etat.Text = t_places.SelectedRows[0].Cells[1].Value.ToString();
           

        }
        

        private void form3_Load(object sender, EventArgs e)
        {
            show();
            

        }
        //modifier les etats des places
        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                Database.connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Database.connection.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("update places set etat =@etat where place=@place", Database.connection);
            cmd.Parameters.AddWithValue("@place", tf_place.Text);
            cmd.Parameters.AddWithValue("@etat", tf_etat.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            show();
            Database.connection.Close();

        }
          private void supprimer_Click(object sender, EventArgs e)
        {
           

        }
        public void exist1()
        {
            try
            {

                Database.connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Database.connection.Close();
                return;
            }
            string query = "select count(place) from places where place = '" + tf_place.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                if (da.GetInt32(0) == 1)
                {
                    ajouter.Enabled = false;
                    supprimer.Enabled = true;
                    modifier.Enabled = true;


                }
                else
                {
                    ajouter.Enabled = true;
                    supprimer.Enabled = false;
                    modifier.Enabled =false;
                }

            }
            Database.connection.Close();
           
            


        }

        private void supprimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database.connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Database.connection.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand("delete places  where place=@place", Database.connection);
            cmd.Parameters.AddWithValue("@place", tf_place.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("delete successfully");
            show();
            Database.connection.Close();
        }
    }
}
