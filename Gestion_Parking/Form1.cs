using System.Data.SqlClient;

namespace Gestion_Parking
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string lg = textBox1.Text;
            string mdp = textBox2.Text;
            //controle le saisie
            string sql = "SELECT * FROM userITBS WHERE Id=@Id and password=@password;";
            try
            {
                Database.connection.Open();
            }
             catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Database.connection.Close();
                return;
            }
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@Id", lg);
            cmd.Parameters.AddWithValue("@password", mdp);
            SqlDataReader reader = cmd.ExecuteReader();
            string nom = "";
            if (reader.Read()){
                nom = reader.GetString(1);
                espace s = new espace();
                s.Show();
                this.Hide();
                Database.connection.Close();
                reader.Close();
            }
            else { MessageBox.Show("Donner errones"); }
            Database.connection.Close();
            reader.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}