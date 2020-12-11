namespace projet_sabour
{
    partial class supprimer_adh
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
            this.radio_nom = new System.Windows.Forms.RadioButton();
            this.radio_email = new System.Windows.Forms.RadioButton();
            this.group_nom_prenom = new System.Windows.Forms.GroupBox();
            this.txt_prenom_supp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nom_supp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.group_email = new System.Windows.Forms.GroupBox();
            this.txt_email_supp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_supp_adh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.group_nom_prenom.SuspendLayout();
            this.group_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_nom
            // 
            this.radio_nom.AutoSize = true;
            this.radio_nom.BackColor = System.Drawing.Color.Transparent;
            this.radio_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_nom.ForeColor = System.Drawing.Color.White;
            this.radio_nom.Location = new System.Drawing.Point(60, 264);
            this.radio_nom.Name = "radio_nom";
            this.radio_nom.Size = new System.Drawing.Size(144, 28);
            this.radio_nom.TabIndex = 15;
            this.radio_nom.TabStop = true;
            this.radio_nom.Text = "Nom complet";
            this.radio_nom.UseVisualStyleBackColor = false;
            this.radio_nom.CheckedChanged += new System.EventHandler(this.radio_nom_CheckedChanged);
            this.radio_nom.MouseEnter += new System.EventHandler(this.radio_nom_MouseEnter);
            this.radio_nom.MouseLeave += new System.EventHandler(this.radio_nom_MouseLeave);
            // 
            // radio_email
            // 
            this.radio_email.AutoSize = true;
            this.radio_email.BackColor = System.Drawing.Color.Transparent;
            this.radio_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_email.ForeColor = System.Drawing.Color.White;
            this.radio_email.Location = new System.Drawing.Point(60, 126);
            this.radio_email.Name = "radio_email";
            this.radio_email.Size = new System.Drawing.Size(78, 28);
            this.radio_email.TabIndex = 14;
            this.radio_email.TabStop = true;
            this.radio_email.Text = "Email";
            this.radio_email.UseVisualStyleBackColor = false;
            this.radio_email.CheckedChanged += new System.EventHandler(this.radio_email_CheckedChanged);
            this.radio_email.MouseEnter += new System.EventHandler(this.radio_email_MouseEnter);
            this.radio_email.MouseLeave += new System.EventHandler(this.radio_email_MouseLeave);
            // 
            // group_nom_prenom
            // 
            this.group_nom_prenom.BackColor = System.Drawing.Color.Transparent;
            this.group_nom_prenom.Controls.Add(this.txt_prenom_supp);
            this.group_nom_prenom.Controls.Add(this.label9);
            this.group_nom_prenom.Controls.Add(this.txt_nom_supp);
            this.group_nom_prenom.Controls.Add(this.label10);
            this.group_nom_prenom.Location = new System.Drawing.Point(279, 224);
            this.group_nom_prenom.Name = "group_nom_prenom";
            this.group_nom_prenom.Size = new System.Drawing.Size(376, 126);
            this.group_nom_prenom.TabIndex = 13;
            this.group_nom_prenom.TabStop = false;
            this.group_nom_prenom.Visible = false;
            // 
            // txt_prenom_supp
            // 
            this.txt_prenom_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom_supp.Location = new System.Drawing.Point(129, 70);
            this.txt_prenom_supp.Name = "txt_prenom_supp";
            this.txt_prenom_supp.Size = new System.Drawing.Size(214, 28);
            this.txt_prenom_supp.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 5;
            this.label9.Text = "Prénom :";
            // 
            // txt_nom_supp
            // 
            this.txt_nom_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_supp.Location = new System.Drawing.Point(129, 33);
            this.txt_nom_supp.Name = "txt_nom_supp";
            this.txt_nom_supp.Size = new System.Drawing.Size(214, 28);
            this.txt_nom_supp.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nom :";
            // 
            // group_email
            // 
            this.group_email.BackColor = System.Drawing.Color.Transparent;
            this.group_email.Controls.Add(this.txt_email_supp);
            this.group_email.Controls.Add(this.label11);
            this.group_email.Location = new System.Drawing.Point(279, 77);
            this.group_email.Name = "group_email";
            this.group_email.Size = new System.Drawing.Size(376, 118);
            this.group_email.TabIndex = 12;
            this.group_email.TabStop = false;
            this.group_email.Visible = false;
            // 
            // txt_email_supp
            // 
            this.txt_email_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_supp.Location = new System.Drawing.Point(129, 42);
            this.txt_email_supp.Name = "txt_email_supp";
            this.txt_email_supp.Size = new System.Drawing.Size(214, 28);
            this.txt_email_supp.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email :";
            // 
            // btn_supp_adh
            // 
            this.btn_supp_adh.BackColor = System.Drawing.Color.Transparent;
            this.btn_supp_adh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supp_adh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_supp_adh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supp_adh.ForeColor = System.Drawing.Color.White;
            this.btn_supp_adh.Location = new System.Drawing.Point(707, 400);
            this.btn_supp_adh.Name = "btn_supp_adh";
            this.btn_supp_adh.Size = new System.Drawing.Size(133, 35);
            this.btn_supp_adh.TabIndex = 11;
            this.btn_supp_adh.Text = "Supprimer";
            this.btn_supp_adh.UseVisualStyleBackColor = false;
            this.btn_supp_adh.Click += new System.EventHandler(this.btn_supp_adh_Click);
            this.btn_supp_adh.MouseEnter += new System.EventHandler(this.btn_supp_adh_MouseEnter);
            this.btn_supp_adh.MouseLeave += new System.EventHandler(this.btn_supp_adh_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 34);
            this.label1.TabIndex = 70;
            this.label1.Text = "Suppression adherent";
            // 
            // supprimer_adh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::projet_sabour.Properties.Resources.Hrabal_trop_bruyante_solitude_livre_ancien;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_nom);
            this.Controls.Add(this.radio_email);
            this.Controls.Add(this.group_nom_prenom);
            this.Controls.Add(this.group_email);
            this.Controls.Add(this.btn_supp_adh);
            this.Name = "supprimer_adh";
            this.Size = new System.Drawing.Size(905, 523);
            this.group_nom_prenom.ResumeLayout(false);
            this.group_nom_prenom.PerformLayout();
            this.group_email.ResumeLayout(false);
            this.group_email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_nom;
        private System.Windows.Forms.RadioButton radio_email;
        private System.Windows.Forms.GroupBox group_nom_prenom;
        private System.Windows.Forms.TextBox txt_prenom_supp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nom_supp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox group_email;
        private System.Windows.Forms.TextBox txt_email_supp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_supp_adh;
        private System.Windows.Forms.Label label1;
    }
}
