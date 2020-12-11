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

namespace projet_sabour
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connection_Click(object sender, EventArgs e)
        {

        }

        private void sign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sign s = new sign();
            s.Show();
            
            
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                txt_email.Clear();
            }
            pictureBox1.BackgroundImage = Properties.Resources.envelope__3_;
            panel2.BackColor = Color.Peru;
            txt_email.ForeColor= Color.Peru;

            pictureBox2.BackgroundImage = Properties.Resources.lock__2_;
            panel1.BackColor = Color.White;
            txt_passe.ForeColor = Color.White;
            if(txt_passe.Text=="Passeword"||txt_passe.Text=="")
            {
                txt_passe.Text = "Passeword";
                txt_passe.PasswordChar = '\0';
            }

        }

        private void txt_passe_Click(object sender, EventArgs e)
        {
            if (txt_passe.Text == "Passeword")
            {
                txt_passe.Clear();
            }
            pictureBox2.BackgroundImage = Properties.Resources.lock__3_;
            panel1.BackColor = Color.Peru;
            txt_passe.ForeColor = Color.Peru;
            txt_passe.PasswordChar = '*';
            pictureBox1.BackgroundImage = Properties.Resources.envelope;
            panel2.BackColor = Color.White;
            txt_email.ForeColor = Color.White;
            if(txt_email.Text=="")
            {
                txt_email.Text = "Email";
            }
        }

        private void btn_connecter_MouseHover(object sender, EventArgs e)
        {
            
            btn_connecter.ForeColor = Color.Peru;
        }

        private void btn_authentification_MouseHover(object sender, EventArgs e)
        {
            
            btn_authentification.ForeColor = Color.Peru;
        }

        private void btn_authentification_MouseLeave(object sender, EventArgs e)
        {
            btn_authentification.ForeColor = Color.White;
        }

        private void btn_connecter_MouseLeave(object sender, EventArgs e)
        {
            btn_connecter.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("test_connection", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@email", txt_email.Text);
            command.Parameters.AddWithValue("@password", txt_passe.Text);
            SqlParameter test = command.Parameters.Add("@profession", SqlDbType.Int);
            test.Direction = ParameterDirection.Output;
            command.ExecuteScalar();
            cn.Close();
            string profession = test.Value.ToString();
            if (profession == "0")
            {
                MessageBox.Show("veuillez authentifier svp");
            }
            else
            {
                if (profession == "-1")
                    MessageBox.Show("veuillez verifier votre mot de passe svp");
                else
                {
                    
                    if(profession=="1")
                    {
                        administrateur g = new administrateur();
                        g.Show();
                        this.Hide();
                    }
                    else
                    {
                        command = new SqlCommand("select libellé from profession where libellé in (select profession from adherents where email like '" + txt_email.Text + "')", cn);
                        cn.Open(); Global.profession = command.ExecuteScalar().ToString();cn.Close();
                        Adherent g = new Adherent();
                        g.Show();

                        this.Hide();
                    }
                }
            }


            
            cn.Close();
        }

        private void btn_authentification_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign s = new sign();
            s.Show();
        }
    }
}
public static class Global
{
    public static string profession;
}
