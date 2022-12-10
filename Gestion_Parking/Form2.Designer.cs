namespace Gestion_Parking
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tf_matricule = new System.Windows.Forms.TextBox();
            this.tf_modele = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_liberer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tf_type = new System.Windows.Forms.ComboBox();
            this.t_vehicule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.Label();
            this.tf_place = new System.Windows.Forms.ComboBox();
            this.databaseBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tf_marque = new System.Windows.Forms.ComboBox();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.t_vehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matricule";
            // 
            // tf_matricule
            // 
            this.tf_matricule.Location = new System.Drawing.Point(100, 77);
            this.tf_matricule.Name = "tf_matricule";
            this.tf_matricule.Size = new System.Drawing.Size(121, 23);
            this.tf_matricule.TabIndex = 3;
            this.tf_matricule.TextChanged += new System.EventHandler(this.tf_matricule_TextChanged);
            // 
            // tf_modele
            // 
            this.tf_modele.Location = new System.Drawing.Point(100, 152);
            this.tf_modele.Name = "tf_modele";
            this.tf_modele.Size = new System.Drawing.Size(121, 23);
            this.tf_modele.TabIndex = 5;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ajouter.Location = new System.Drawing.Point(37, 268);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(163, 50);
            this.btn_ajouter.TabIndex = 6;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_liberer
            // 
            this.btn_liberer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_liberer.Location = new System.Drawing.Point(37, 333);
            this.btn_liberer.Name = "btn_liberer";
            this.btn_liberer.Size = new System.Drawing.Size(163, 50);
            this.btn_liberer.TabIndex = 7;
            this.btn_liberer.Text = "Liberer";
            this.btn_liberer.UseVisualStyleBackColor = false;
            this.btn_liberer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_modifier.Location = new System.Drawing.Point(37, 398);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(163, 47);
            this.btn_modifier.TabIndex = 8;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(366, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gestion parking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // tf_type
            // 
            this.tf_type.FormattingEnabled = true;
            this.tf_type.Items.AddRange(new object[] {
            "Voiture",
            "Camion sans R",
            "Camion avec R"});
            this.tf_type.Location = new System.Drawing.Point(100, 190);
            this.tf_type.Name = "tf_type";
            this.tf_type.Size = new System.Drawing.Size(121, 23);
            this.tf_type.TabIndex = 12;
            // 
            // t_vehicule
            // 
            this.t_vehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_vehicule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.dataGridViewTextBoxColumn1});
            this.t_vehicule.Location = new System.Drawing.Point(249, 77);
            this.t_vehicule.Name = "t_vehicule";
            this.t_vehicule.RowTemplate.Height = 25;
            this.t_vehicule.Size = new System.Drawing.Size(539, 345);
            this.t_vehicule.TabIndex = 15;
            this.t_vehicule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_vehicule_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricule";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marque";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modele";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "place";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Place.Location = new System.Drawing.Point(16, 224);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(58, 25);
            this.Place.TabIndex = 18;
            this.Place.Text = "Place";
            // 
            // tf_place
            // 
            this.tf_place.FormattingEnabled = true;
            this.tf_place.Location = new System.Drawing.Point(100, 229);
            this.tf_place.Name = "tf_place";
            this.tf_place.Size = new System.Drawing.Size(121, 23);
            this.tf_place.TabIndex = 19;
            // 
            // databaseBindingSource5
            // 
            this.databaseBindingSource5.DataSource = typeof(Gestion_Parking.Database);
            // 
            // databaseBindingSource3
            // 
            this.databaseBindingSource3.DataSource = typeof(Gestion_Parking.Database);
            // 
            // tf_marque
            // 
            this.tf_marque.FormattingEnabled = true;
            this.tf_marque.Items.AddRange(new object[] {
            "ALFA ROMEO",
            "AUDI",
            "BMW",
            "CHERY",
            "CHEVROLET",
            "FIAT",
            "FORD",
            "HAVAL",
            "HONDA",
            "HYUNDAI",
            "JAGUAR",
            "JEEP",
            "KIA",
            "LAND-ROVER",
            "MAHINDRA",
            "MARCEDES-BENZ",
            "MG",
            "MINI",
            "MITSUBISHI",
            "NISSAN",
            "OPEL",
            "PEUGEOT",
            "PORSCHE",
            "RENAULT",
            "SEAT",
            "SKODA",
            "SUZUKI",
            "TOYOTA",
            "VOLKSWAGEN",
            "MAN",
            "VOLVO",
            "ISUZU"});
            this.tf_marque.Location = new System.Drawing.Point(100, 113);
            this.tf_marque.Name = "tf_marque";
            this.tf_marque.Size = new System.Drawing.Size(121, 23);
            this.tf_marque.TabIndex = 20;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(Gestion_Parking.Database);
            // 
            // databaseBindingSource1
            // 
            this.databaseBindingSource1.DataSource = typeof(Gestion_Parking.Database);
            // 
            // databaseBindingSource2
            // 
            this.databaseBindingSource2.DataSource = typeof(Gestion_Parking.Database);
            // 
            // databaseBindingSource4
            // 
            this.databaseBindingSource4.DataSource = typeof(Gestion_Parking.Database);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(774, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(730, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "<-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tf_marque);
            this.Controls.Add(this.tf_place);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.t_vehicule);
            this.Controls.Add(this.tf_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_liberer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.tf_modele);
            this.Controls.Add(this.tf_matricule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_vehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tf_matricule;
        private TextBox tf_modele;
        private Button btn_ajouter;
        private Button btn_liberer;
        private Button btn_modifier;
        private Label label4;
        private Label label5;
        private ComboBox tf_type;
       // private Button button1;
        //private DataGridViewCellEventHandler dataGridView1_CellContentClick;
      //  private Button btn_search;
        //private DataGridView dataGridView2;
        private DataGridView t_vehicule;
        private Label Place;
        private ComboBox tf_place;
        private ComboBox tf_marque;
        private BindingSource databaseBindingSource;
        private BindingSource databaseBindingSource1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCellEventHandler t_vehicule_CellContentClick;
        private EventHandler comboBox1_SelectedIndexChanged;
        private BindingSource databaseBindingSource3;
        private BindingSource databaseBindingSource2;
        private BindingSource databaseBindingSource4;
        private BindingSource databaseBindingSource5;
        private Label label6;
        private Label label7;

        //public EventHandler Form2_Load { get; private set; }
    }
}