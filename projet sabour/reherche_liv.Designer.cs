namespace projet_sabour
{
    partial class reherche_liv
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
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.check_titre = new System.Windows.Forms.CheckBox();
            this.check_auteur = new System.Windows.Forms.CheckBox();
            this.check_theme = new System.Windows.Forms.CheckBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.cmb_theme = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_titre
            // 
            this.txt_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titre.Location = new System.Drawing.Point(190, 130);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(245, 28);
            this.txt_titre.TabIndex = 1;
            this.txt_titre.Visible = false;
            this.txt_titre.TextChanged += new System.EventHandler(this.txt_titre_TextChanged);
            // 
            // check_titre
            // 
            this.check_titre.AutoSize = true;
            this.check_titre.BackColor = System.Drawing.Color.Transparent;
            this.check_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_titre.ForeColor = System.Drawing.Color.White;
            this.check_titre.Location = new System.Drawing.Point(16, 132);
            this.check_titre.Name = "check_titre";
            this.check_titre.Size = new System.Drawing.Size(69, 28);
            this.check_titre.TabIndex = 2;
            this.check_titre.Text = "Titre";
            this.check_titre.UseVisualStyleBackColor = false;
            this.check_titre.Click += new System.EventHandler(this.check_titre_Click);
            this.check_titre.MouseEnter += new System.EventHandler(this.check_titre_MouseEnter);
            this.check_titre.MouseLeave += new System.EventHandler(this.check_titre_MouseLeave);
            // 
            // check_auteur
            // 
            this.check_auteur.AutoSize = true;
            this.check_auteur.BackColor = System.Drawing.Color.Transparent;
            this.check_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_auteur.ForeColor = System.Drawing.Color.White;
            this.check_auteur.Location = new System.Drawing.Point(16, 172);
            this.check_auteur.Name = "check_auteur";
            this.check_auteur.Size = new System.Drawing.Size(88, 28);
            this.check_auteur.TabIndex = 3;
            this.check_auteur.Text = "Auteur";
            this.check_auteur.UseVisualStyleBackColor = false;
            this.check_auteur.Click += new System.EventHandler(this.check_titre_Click);
            this.check_auteur.MouseEnter += new System.EventHandler(this.check_auteur_MouseEnter);
            this.check_auteur.MouseLeave += new System.EventHandler(this.check_auteur_MouseLeave);
            // 
            // check_theme
            // 
            this.check_theme.AutoSize = true;
            this.check_theme.BackColor = System.Drawing.Color.Transparent;
            this.check_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_theme.ForeColor = System.Drawing.Color.White;
            this.check_theme.Location = new System.Drawing.Point(16, 212);
            this.check_theme.Name = "check_theme";
            this.check_theme.Size = new System.Drawing.Size(93, 28);
            this.check_theme.TabIndex = 4;
            this.check_theme.Text = "Théme";
            this.check_theme.UseVisualStyleBackColor = false;
            this.check_theme.Click += new System.EventHandler(this.check_titre_Click);
            this.check_theme.MouseEnter += new System.EventHandler(this.check_theme_MouseEnter);
            this.check_theme.MouseLeave += new System.EventHandler(this.check_theme_MouseLeave);
            // 
            // txt_auteur
            // 
            this.txt_auteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_auteur.Location = new System.Drawing.Point(190, 170);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(245, 28);
            this.txt_auteur.TabIndex = 5;
            this.txt_auteur.Visible = false;
            this.txt_auteur.TextChanged += new System.EventHandler(this.txt_auteur_TextChanged);
            // 
            // cmb_theme
            // 
            this.cmb_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_theme.FormattingEnabled = true;
            this.cmb_theme.Location = new System.Drawing.Point(190, 209);
            this.cmb_theme.Name = "cmb_theme";
            this.cmb_theme.Size = new System.Drawing.Size(245, 30);
            this.cmb_theme.TabIndex = 6;
            this.cmb_theme.Visible = false;
            this.cmb_theme.SelectedIndexChanged += new System.EventHandler(this.cmb_theme_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 240);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(317, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 70;
            this.label1.Text = "Recherche livre";
            // 
            // reherche_liv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_sabour.Properties.Resources.Hrabal_trop_bruyante_solitude_livre_ancien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_theme);
            this.Controls.Add(this.txt_auteur);
            this.Controls.Add(this.check_theme);
            this.Controls.Add(this.check_auteur);
            this.Controls.Add(this.check_titre);
            this.Controls.Add(this.txt_titre);
            this.Name = "reherche_liv";
            this.Size = new System.Drawing.Size(905, 523);
            this.Load += new System.EventHandler(this.reherche_liv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.CheckBox check_titre;
        private System.Windows.Forms.CheckBox check_auteur;
        private System.Windows.Forms.CheckBox check_theme;
        private System.Windows.Forms.TextBox txt_auteur;
        private System.Windows.Forms.ComboBox cmb_theme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
