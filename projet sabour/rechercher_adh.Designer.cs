namespace projet_sabour
{
    partial class rechercher_adh
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.profession_rech = new System.Windows.Forms.ComboBox();
            this.cin_rech = new System.Windows.Forms.TextBox();
            this.check_cin = new System.Windows.Forms.CheckBox();
            this.check_nom = new System.Windows.Forms.CheckBox();
            this.check_email = new System.Windows.Forms.CheckBox();
            this.check_profession = new System.Windows.Forms.CheckBox();
            this.email_rech = new System.Windows.Forms.TextBox();
            this.nom_rech = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // profession_rech
            // 
            this.profession_rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profession_rech.FormattingEnabled = true;
            this.profession_rech.Location = new System.Drawing.Point(379, 221);
            this.profession_rech.Name = "profession_rech";
            this.profession_rech.Size = new System.Drawing.Size(182, 28);
            this.profession_rech.TabIndex = 87;
            this.profession_rech.SelectedIndexChanged += new System.EventHandler(this.profession_rech_SelectedIndexChanged);
            // 
            // cin_rech
            // 
            this.cin_rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin_rech.Location = new System.Drawing.Point(379, 100);
            this.cin_rech.Name = "cin_rech";
            this.cin_rech.Size = new System.Drawing.Size(182, 27);
            this.cin_rech.TabIndex = 86;
            this.cin_rech.TextChanged += new System.EventHandler(this.cin_rech_TextChanged);
            // 
            // check_cin
            // 
            this.check_cin.AutoSize = true;
            this.check_cin.BackColor = System.Drawing.Color.Transparent;
            this.check_cin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_cin.ForeColor = System.Drawing.Color.White;
            this.check_cin.Location = new System.Drawing.Point(38, 97);
            this.check_cin.Name = "check_cin";
            this.check_cin.Size = new System.Drawing.Size(63, 28);
            this.check_cin.TabIndex = 88;
            this.check_cin.Text = "CIN";
            this.check_cin.UseVisualStyleBackColor = false;
            this.check_cin.CheckedChanged += new System.EventHandler(this.check_cin_CheckedChanged);
            this.check_cin.MouseEnter += new System.EventHandler(this.check_cin_MouseEnter);
            this.check_cin.MouseLeave += new System.EventHandler(this.check_cin_MouseLeave);
            // 
            // check_nom
            // 
            this.check_nom.AutoSize = true;
            this.check_nom.BackColor = System.Drawing.Color.Transparent;
            this.check_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_nom.ForeColor = System.Drawing.Color.White;
            this.check_nom.Location = new System.Drawing.Point(38, 140);
            this.check_nom.Name = "check_nom";
            this.check_nom.Size = new System.Drawing.Size(73, 28);
            this.check_nom.TabIndex = 89;
            this.check_nom.Text = "Nom";
            this.check_nom.UseVisualStyleBackColor = false;
            this.check_nom.CheckedChanged += new System.EventHandler(this.check_nom_CheckedChanged);
            this.check_nom.MouseEnter += new System.EventHandler(this.check_nom_MouseEnter);
            this.check_nom.MouseLeave += new System.EventHandler(this.check_nom_MouseLeave);
            // 
            // check_email
            // 
            this.check_email.AutoSize = true;
            this.check_email.BackColor = System.Drawing.Color.Transparent;
            this.check_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_email.ForeColor = System.Drawing.Color.White;
            this.check_email.Location = new System.Drawing.Point(38, 181);
            this.check_email.Name = "check_email";
            this.check_email.Size = new System.Drawing.Size(79, 28);
            this.check_email.TabIndex = 90;
            this.check_email.Text = "Email";
            this.check_email.UseVisualStyleBackColor = false;
            this.check_email.CheckedChanged += new System.EventHandler(this.check_email_CheckedChanged);
            this.check_email.MouseEnter += new System.EventHandler(this.check_email_MouseEnter);
            this.check_email.MouseLeave += new System.EventHandler(this.check_email_MouseLeave);
            // 
            // check_profession
            // 
            this.check_profession.AutoSize = true;
            this.check_profession.BackColor = System.Drawing.Color.Transparent;
            this.check_profession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_profession.ForeColor = System.Drawing.Color.White;
            this.check_profession.Location = new System.Drawing.Point(38, 221);
            this.check_profession.Name = "check_profession";
            this.check_profession.Size = new System.Drawing.Size(120, 28);
            this.check_profession.TabIndex = 91;
            this.check_profession.Text = "Profession";
            this.check_profession.UseVisualStyleBackColor = false;
            this.check_profession.CheckedChanged += new System.EventHandler(this.check_profession_CheckedChanged);
            this.check_profession.MouseEnter += new System.EventHandler(this.check_profession_MouseEnter);
            this.check_profession.MouseLeave += new System.EventHandler(this.check_profession_MouseLeave);
            // 
            // email_rech
            // 
            this.email_rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_rech.Location = new System.Drawing.Point(379, 181);
            this.email_rech.Name = "email_rech";
            this.email_rech.Size = new System.Drawing.Size(182, 27);
            this.email_rech.TabIndex = 92;
            this.email_rech.TextChanged += new System.EventHandler(this.email_rech_TextChanged);
            // 
            // nom_rech
            // 
            this.nom_rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_rech.Location = new System.Drawing.Point(379, 140);
            this.nom_rech.Name = "nom_rech";
            this.nom_rech.Size = new System.Drawing.Size(182, 27);
            this.nom_rech.TabIndex = 93;
            this.nom_rech.TextChanged += new System.EventHandler(this.nom_rech_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(286, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 34);
            this.label1.TabIndex = 94;
            this.label1.Text = "Recherche adherent";
            // 
            // rechercher_adh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_sabour.Properties.Resources.Hrabal_trop_bruyante_solitude_livre_ancien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom_rech);
            this.Controls.Add(this.email_rech);
            this.Controls.Add(this.check_profession);
            this.Controls.Add(this.check_email);
            this.Controls.Add(this.check_nom);
            this.Controls.Add(this.check_cin);
            this.Controls.Add(this.profession_rech);
            this.Controls.Add(this.cin_rech);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rechercher_adh";
            this.Size = new System.Drawing.Size(905, 523);
            this.Load += new System.EventHandler(this.rechercher_adh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox profession_rech;
        private System.Windows.Forms.TextBox cin_rech;
        private System.Windows.Forms.CheckBox check_cin;
        private System.Windows.Forms.CheckBox check_nom;
        private System.Windows.Forms.CheckBox check_email;
        private System.Windows.Forms.CheckBox check_profession;
        private System.Windows.Forms.TextBox email_rech;
        private System.Windows.Forms.TextBox nom_rech;
        private System.Windows.Forms.Label label1;
    }
}
