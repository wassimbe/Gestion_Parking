namespace Gestion_Parking
{
    partial class form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tf_place = new System.Windows.Forms.TextBox();
            this.tf_etat = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_places = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.t_places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etat :";
            // 
            // tf_place
            // 
            this.tf_place.Location = new System.Drawing.Point(116, 70);
            this.tf_place.Name = "tf_place";
            this.tf_place.Size = new System.Drawing.Size(110, 23);
            this.tf_place.TabIndex = 3;
            this.tf_place.TextChanged += new System.EventHandler(this.tf_place_TextChanged);
            // 
            // tf_etat
            // 
            this.tf_etat.Location = new System.Drawing.Point(116, 113);
            this.tf_etat.Name = "tf_etat";
            this.tf_etat.Size = new System.Drawing.Size(110, 23);
            this.tf_etat.TabIndex = 4;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ajouter.ForeColor = System.Drawing.Color.Black;
            this.ajouter.Location = new System.Drawing.Point(42, 180);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(143, 44);
            this.ajouter.TabIndex = 6;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.modifier.Location = new System.Drawing.Point(42, 305);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(143, 41);
            this.modifier.TabIndex = 7;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.supprimer.Location = new System.Drawing.Point(42, 245);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(143, 42);
            this.supprimer.TabIndex = 8;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestion des places";
            // 
            // t_places
            // 
            this.t_places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.Etat});
            this.t_places.Location = new System.Drawing.Point(268, 75);
            this.t_places.Name = "t_places";
            this.t_places.RowTemplate.Height = 25;
            this.t_places.Size = new System.Drawing.Size(243, 304);
            this.t_places.TabIndex = 11;
            this.t_places.MouseClick += new System.Windows.Forms.MouseEventHandler(this.t_places_MouseClick);
            // 
            // Place
            // 
            this.Place.HeaderText = "Place";
            this.Place.Name = "Place";
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(569, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(536, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "<-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(Gestion_Parking.Database);
            // 
            // form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_places);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.tf_etat);
            this.Controls.Add(this.tf_place);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form3";
            this.Text = "Gestion  des places";
            this.Load += new System.EventHandler(this.form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox tf_place;
        private TextBox tf_etat;
        private Button ajouter;
        private Button modifier;
        private Button supprimer;
        private Label label1;
        private DataGridView t_places;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn Etat;
        private Label label4;
        private Label label5;
        private BindingSource databaseBindingSource;
    }
}