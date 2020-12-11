namespace projet_sabour
{
    partial class ajout_exemplaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajout_exemplaire));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_etat = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_initialiser = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.date_edition = new System.Windows.Forms.MaskedTextBox();
            this.cmb_livre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 34);
            this.label1.TabIndex = 86;
            this.label1.Text = "Ajout exemplaire";
            // 
            // txt_etat
            // 
            this.txt_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_etat.Location = new System.Drawing.Point(430, 172);
            this.txt_etat.Name = "txt_etat";
            this.txt_etat.Size = new System.Drawing.Size(182, 27);
            this.txt_etat.TabIndex = 81;
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(430, 107);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(182, 27);
            this.txt_code.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(217, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Date d\'édition :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Livre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(217, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Etat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Code :";
            // 
            // btn_initialiser
            // 
            this.btn_initialiser.BackColor = System.Drawing.Color.Transparent;
            this.btn_initialiser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_initialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_initialiser.ForeColor = System.Drawing.Color.White;
            this.btn_initialiser.Location = new System.Drawing.Point(762, 397);
            this.btn_initialiser.Name = "btn_initialiser";
            this.btn_initialiser.Size = new System.Drawing.Size(115, 30);
            this.btn_initialiser.TabIndex = 71;
            this.btn_initialiser.Text = "Initialiser";
            this.btn_initialiser.UseVisualStyleBackColor = false;
            this.btn_initialiser.Click += new System.EventHandler(this.btn_initialiser_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.BackColor = System.Drawing.Color.Transparent;
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Location = new System.Drawing.Point(597, 397);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(118, 30);
            this.btn_enregistrer.TabIndex = 70;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // date_edition
            // 
            this.date_edition.Location = new System.Drawing.Point(430, 310);
            this.date_edition.Mask = "00/00/0000";
            this.date_edition.Name = "date_edition";
            this.date_edition.Size = new System.Drawing.Size(182, 22);
            this.date_edition.TabIndex = 87;
            this.date_edition.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_livre
            // 
            this.cmb_livre.FormattingEnabled = true;
            this.cmb_livre.Location = new System.Drawing.Point(430, 240);
            this.cmb_livre.Name = "cmb_livre";
            this.cmb_livre.Size = new System.Drawing.Size(182, 24);
            this.cmb_livre.TabIndex = 88;
            // 
            // ajout_exemplaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.cmb_livre);
            this.Controls.Add(this.date_edition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_etat);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_initialiser);
            this.Controls.Add(this.btn_enregistrer);
            this.Name = "ajout_exemplaire";
            this.Size = new System.Drawing.Size(905, 523);
            this.Load += new System.EventHandler(this.ajout_exemplaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_etat;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_initialiser;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.MaskedTextBox date_edition;
        private System.Windows.Forms.ComboBox cmb_livre;
    }
}
