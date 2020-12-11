using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace projet_sabour
{
    public partial class sign : Form
    {
        SqlCommand command;
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        DataTable dt=new DataTable();
        public sign()
        {
            InitializeComponent();
        }

        private void supprimer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            txt_nom.Clear();
            
            txt_email.Clear();
            txt_passe.Clear();
            txt_vpasse.Clear();
            txt_passe.Text = "Passeword";
            txt_passe.ForeColor = Color.Gray;
            txt_passe.PasswordChar = '\0';
            txt_email.Text = "Email";
            txt_email.ForeColor = Color.Gray;
            txt_vpasse.Text = "Passeword";
            txt_vpasse.ForeColor = Color.Gray;
            txt_vpasse.PasswordChar = '\0';
            txt_nom.Text = "Nom";
            txt_nom.ForeColor = Color.Gray;

        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            int a = 0;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txt_email.Text);
            if (!match.Success)
            {
                l_email.Visible = true;
            }
            else
            {
                l_email.Visible = false; a += 1;
            }
            if (txt_vpasse.Text == "" || txt_vpasse.Text == "Passeword")
            {
                txt_vpasse.ForeColor = Color.Red;
            }
            else
            {
                a += 1;
            }
            regex = new Regex(@"^[A-Za-z0-9]$");
            match = regex.Match(txt_passe.Text);
            if (!match.Success)
            {
                l_passe.Visible = true;
            }
            else
            {
                l_passe.Visible = false; a += 1;
            }
            if (a == 3)
            {
                cn.Open();
                command.Parameters.Clear();
                command = new SqlCommand("ajouter_adherent", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nom", txt_nom.Text);
                command.Parameters.AddWithValue("@email", txt_email.Text);
                command.Parameters.AddWithValue("@passeword", txt_passe.Text);
                SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
                test.Direction = ParameterDirection.Output;
                command.ExecuteScalar();
                if (test.Value.ToString() == "0")
                {
                    MessageBox.Show("vous avez authentifier avec succes");
                }
                else
                {
                    MessageBox.Show("vous avez déjà un compte");
                }
                cn.Close();
                Connexion c = new Connexion();
                c.Show();
                this.Hide();
            }
        }
        
        private void sign_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_profession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enregistrer_MouseEnter(object sender, EventArgs e)
        {
            btn_enregistrer.ForeColor = Color.Peru;
        }

        private void btn_enregistrer_MouseLeave(object sender, EventArgs e)
        {
            btn_enregistrer.ForeColor = Color.White;
        }

        private void txt_nom_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == "Nom")
            {
                txt_nom.Clear();
            }
                txt_nom.ForeColor = Color.Peru;
                nom.BackgroundImage = Properties.Resources.user_silhouette__1_;
                pnom.BackColor = Color.Peru;
            
            if (txt_vpasse.Text == "" || txt_vpasse.Text == "Passeword")
            {
                txt_vpasse.Text = "Passeword";
                txt_vpasse.ForeColor = Color.Gray;
                txt_vpasse.PasswordChar = '\0';
            }
            else
            {
                txt_vpasse.ForeColor = Color.White;
                vpasse.BackgroundImage = Properties.Resources.lock__2_;
                pvpasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_passe.Text == "" || txt_passe.Text == "Passeword")
            {
                txt_passe.Text = "Passeword";
                txt_passe.ForeColor = Color.Gray;
                txt_passe.PasswordChar = '\0';
            }
            else
            {
                txt_passe.ForeColor = Color.White;
                passe.BackgroundImage = Properties.Resources.lock__2_;
                ppasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_email.Text == "" || txt_email.Text == "Email")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Gray;
            }
            else
            {
                txt_email.ForeColor = Color.White;
                email.BackgroundImage = Properties.Resources.envelope;
                pemail.BackColor = Color.White;
            }

        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Clear(); }
                txt_email.ForeColor = Color.Peru;
                email.BackgroundImage = Properties.Resources.envelope__3_;
                pemail.BackColor = Color.Peru;
            
            if (txt_vpasse.Text == "" || txt_vpasse.Text == "Passeword")
            {
                txt_vpasse.Text = "Passeword";
                txt_vpasse.ForeColor = Color.Gray;
                txt_vpasse.PasswordChar = '\0';
            }
            else
            {
                txt_vpasse.ForeColor = Color.White;
                vpasse.BackgroundImage = Properties.Resources.lock__2_;
                pvpasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_passe.Text == "" || txt_passe.Text == "Passeword")
            {
                txt_passe.Text = "Passeword";
                txt_passe.ForeColor = Color.Gray;
                txt_passe.PasswordChar = '\0';
            }
            else
            {
                txt_passe.ForeColor = Color.White;
                passe.BackgroundImage = Properties.Resources.lock__2_;
                ppasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_nom.Text == "" || txt_nom.Text == "Nom")
            {
                txt_nom.Text = "Nom";
                txt_nom.ForeColor = Color.Gray;
            }
            else
            {
                txt_nom.ForeColor = Color.White;
                nom.BackgroundImage = Properties.Resources.user_silhouette;
                pnom.BackColor = Color.White;
            }
        }

        private void txt_passe_Click(object sender, EventArgs e)
        {
            if (txt_passe.Text == "Passeword")
            {
                txt_passe.Clear();
            }
                txt_passe.ForeColor = Color.Peru;
                passe.BackgroundImage = Properties.Resources.lock__3_;
                ppasse.BackColor = Color.Peru;
                txt_passe.PasswordChar = '*';
            
            if (txt_vpasse.Text == "" || txt_vpasse.Text == "Passeword")
            {
                txt_vpasse.Text = "Passeword";
                txt_vpasse.ForeColor = Color.Gray;
                txt_vpasse.PasswordChar = '\0';
            }
            else
            {
                txt_vpasse.ForeColor = Color.White;
                vpasse.BackgroundImage = Properties.Resources.lock__2_;
                pvpasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_email.Text == "" || txt_email.Text=="Email")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Gray;
            }
            else
            {
                txt_email.ForeColor = Color.White;
                email.BackgroundImage = Properties.Resources.envelope;
                pemail.BackColor = Color.White;
            }
            if (txt_nom.Text == ""|| txt_nom.Text == "Nom")
            {
                txt_nom.Text = "Nom";
                txt_nom.ForeColor = Color.Gray;
            }
            else
            {
                txt_nom.ForeColor = Color.White;
                nom.BackgroundImage = Properties.Resources.user_silhouette;
                pnom.BackColor = Color.White;
            }
        }

        private void txt_vpasse_Click(object sender, EventArgs e)
        {
            if (txt_vpasse.Text == "Passeword")
            {
                txt_vpasse.Clear();
            }
                txt_vpasse.ForeColor = Color.Peru;
                vpasse.BackgroundImage = Properties.Resources.lock__3_;
                pvpasse.BackColor = Color.Peru;
                txt_vpasse.PasswordChar = '*';
            
            if (txt_passe.Text == "" || txt_passe.Text == "Passeword")
            {
                txt_passe.Text = "Passeword";
                txt_passe.ForeColor = Color.Gray;
                txt_passe.PasswordChar = '\0';
            }
            else
            {
                txt_passe.ForeColor = Color.White;
                passe.BackgroundImage = Properties.Resources.lock__2_;
                ppasse.BackColor = Color.White;
                txt_passe.PasswordChar = '*';
            }
            if (txt_email.Text == "" || txt_email.Text == "Email")
            {
                txt_email.Text = "Email";
                txt_email.ForeColor = Color.Gray;
            }
            else
            {
                txt_email.ForeColor = Color.White;
                email.BackgroundImage = Properties.Resources.envelope;
                pemail.BackColor = Color.White;
            }
            if (txt_nom.Text == "" || txt_nom.Text == "Nom")
            {
                txt_nom.Text = "Nom";
                txt_nom.ForeColor = Color.Gray;
            }
            else
            {
                txt_nom.ForeColor = Color.White;
                nom.BackgroundImage = Properties.Resources.user_silhouette;
                pnom.BackColor = Color.White;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void validation(object sender, EventArgs e)
        {
            if(txt_vpasse.Text!=txt_passe.Text)
            {
                txt_vpasse.ForeColor = Color.Red;

            }
            else
            {
                txt_vpasse.ForeColor = Color.White;
            }

        }
        private void txt_vpasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_passe_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            
                
        }

        
    }
}

