using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Gestion_Parking
{
    public partial class Form2 : Form
    {
        private SqlCommand cmd;


        public Form2()
        {
            InitializeComponent();
            btn_ajouter.Enabled = false;
            btn_liberer.Enabled = false;
            btn_modifier.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        // Button pour ajouter les vehicules
        private void button1_Click(object sender, EventArgs e)
        {
            if(tf_marque.Text !="" && tf_modele.Text !="" && tf_type.Text != "" && tf_place.Text != "")
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
                SqlCommand cmd = new SqlCommand("insert into vehicule values (@Id,@Marque,@Modele,@Type, @place)", Database.connection);
                SqlCommand cmd2 = new SqlCommand("update places set etat='occupee' where place=@place", Database.connection);
                if (cmd != null && cmd2 != null)
                {
                    cmd2.Parameters.AddWithValue("@place", tf_place.Text);
                    cmd.Parameters.AddWithValue("@Id", tf_matricule.Text);
                    cmd.Parameters.AddWithValue("@Marque", tf_marque.Text);
                    cmd.Parameters.AddWithValue("@Modele", tf_modele.Text);
                    cmd.Parameters.AddWithValue("@Type", tf_type.Text);
                    cmd.Parameters.AddWithValue("@place", tf_place.Text);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Insert successfully");
                }
                else
                {
                    MessageBox.Show("Il faut faut remplir les champs");
                }
                show();
                Database.connection.Close();
                tf_place.Items.Clear();
                getFreePlaces();
                tf_matricule.Text = null;
                tf_marque.Text = null;
                tf_modele.Text = null;
                tf_place.Text = null;
                tf_type.Text = null;
            }
            else
            {
                MessageBox.Show("entrer les données");
            }

           


        }

        //button pour liberer les vehicules
        private void button2_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Le payement enregistrer?", "libérer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete vehicule where Id=@Id", Database.connection);
                SqlCommand cmd2 = new SqlCommand("update places set etat='libre' where place=@place", Database.connection);
                cmd2.Parameters.AddWithValue("@place", tf_place.Text);
                cmd.Parameters.AddWithValue("@Id", tf_matricule.Text);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                show();
                Database.connection.Close();
                tf_place.Items.Clear();
                getFreePlaces();
                tf_matricule.Text = null;
                tf_marque.Text = null;
                tf_modele.Text = null;
                tf_place.Text = null;
                tf_type.Text = null;
            }
            else
            {
                MessageBox.Show("impossible ! payement non enregistrer");
            }
        }

        //button pour modifier les information des vehicules
        private void btn_modifier_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("update vehicule set marque =@marque,modele=@modele,type=@type where Id=@Id", Database.connection);
            cmd.Parameters.AddWithValue("@Id", tf_matricule.Text);
            cmd.Parameters.AddWithValue("@Marque", tf_marque.Text);
            cmd.Parameters.AddWithValue("@Modele", tf_modele.Text);
            cmd.Parameters.AddWithValue("@Type", tf_type.Text);
            cmd.Parameters.AddWithValue("@place", tf_place.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            show();
            Database.connection.Close();
            tf_matricule.Text = null;
            tf_marque.Text = null;
            tf_modele.Text = null;
            tf_place.Text = null;
            tf_type.Text = null;

        }

        void show()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from vehicule", Database.connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            t_vehicule.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = t_vehicule.Rows.Add();
                t_vehicule.Rows[n].Cells[0].Value = dr[0].ToString();
                t_vehicule.Rows[n].Cells[1].Value = dr[1].ToString();
                t_vehicule.Rows[n].Cells[2].Value = dr[2].ToString();
                t_vehicule.Rows[n].Cells[3].Value = dr[3].ToString();
                t_vehicule.Rows[n].Cells[4].Value = dr[4].ToString();
            }
            Database.connection.Close();
        }
        // lier les textbox par les rows de tableau par clik
        private void t_vehicule_MouseClick(object sender, MouseEventArgs e)
        {
            tf_matricule.Text = t_vehicule.SelectedRows[0].Cells[0].Value.ToString();
            tf_marque.Text = t_vehicule.SelectedRows[0].Cells[1].Value.ToString();
            tf_modele.Text = t_vehicule.SelectedRows[0].Cells[2].Value.ToString();
            tf_type.Text = t_vehicule.SelectedRows[0].Cells[3].Value.ToString();
            tf_place.Text = t_vehicule.SelectedRows[0].Cells[4].Value.ToString();

        }

        //remplir le combobox des places par la base de donné
        void getFreePlaces()
        {
            tf_place.Items.Clear();
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
            SqlCommand cmd = new SqlCommand("select place from places where etat='libre'", Database.connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tf_place.Items.Add(dr["place"].ToString());
            }
            Database.connection.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            getFreePlaces();
            show();
        }
        //exit
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // retour au interface espace
        private void label7_Click(object sender, EventArgs e)
        {
            espace s = new espace();
            s.Show();
            this.Hide();
        }
        //remplissage des textbox
        private void tf_matricule_TextChanged(object sender, EventArgs e)
        {
            if(tf_matricule.Text!="")
            {
                exist();
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
                string query = "select marque,modele,type,place from vehicule where id=@id";
                SqlCommand cmd = new SqlCommand(query, Database.connection);
                cmd.Parameters.AddWithValue("@id", string.Format(tf_matricule.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    tf_marque.Text = da.GetValue(0).ToString();
                    tf_modele.Text = da.GetValue(1).ToString();
                    tf_type.Text = da.GetValue(2).ToString();
                    tf_place.Text = da.GetValue(3).ToString();
                }

            }
            else
            {
                btn_ajouter.Enabled = false;
                btn_liberer.Enabled = false;
                btn_modifier.Enabled = false;
                tf_marque.Text = null;
                tf_modele.Text = null;
                tf_type.Text = null;
                tf_place.Text = null;
            }
            Database.connection.Close();
        }
        //controle d'existance de matricule
        public void exist()
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
            string query = "select count(id) from vehicule where id = '" + tf_matricule.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Database.connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                if (da.GetInt32(0) == 1)
                {
                    btn_liberer.Enabled = true;
                    btn_modifier.Enabled = true;
                    btn_ajouter.Enabled = false;


                }
                else
                {
                    btn_liberer.Enabled =false;
                    btn_modifier.Enabled = false;
                    btn_ajouter.Enabled = true;
                }
            }Database.connection.Close();


        }
    }
   

}
