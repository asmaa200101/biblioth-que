using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_sabour
{
    public partial class supprimer_adh : UserControl
    {
        public supprimer_adh()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIOTHEQUE;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        private void btn_supp_adh_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (radio_nom.Checked)
            {
                command = new SqlCommand("supprimer_adherent_nom", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nom", txt_nom_supp.Text);
                command.Parameters.AddWithValue("@prenom", txt_prenom_supp.Text);
                SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
                test.Direction = ParameterDirection.Output;
                command.ExecuteScalar();
                if (test.Value.ToString() == "0")
                {
                    MessageBox.Show("vous avez supprimer l'adhérent avec succés");
                }
                else
                {
                    MessageBox.Show("l'adérent n'existe pas");
                }
            }
            else
            {
                if (radio_email.Checked)
                {
                    command = new SqlCommand("supprimer_adherent_email", cn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@email", txt_email_supp.Text);
                    SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
                    test.Direction = ParameterDirection.Output;
                    command.ExecuteScalar();
                    if (test.Value.ToString() == "0")
                    {
                        MessageBox.Show("vous avez supprimer l'adhérent avec succés");
                    }
                    else
                    {
                        MessageBox.Show("l'adérent n'existe pas");
                    }
                }
            }
            cn.Close();
        }

        private void btn_supp_adh_MouseEnter(object sender, EventArgs e)
        {
            btn_supp_adh.ForeColor = Color.Gray;
        }

        private void btn_supp_adh_MouseLeave(object sender, EventArgs e)
        {
            btn_supp_adh.ForeColor = Color.White;
        }

        private void radio_email_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_email.Checked)
            {
                group_email.Show();
            }
            else
            {
                group_email.Hide();
            }
        }

        private void radio_nom_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nom.Checked)
            {
                group_nom_prenom.Show();
            }
            else
            {
                group_nom_prenom.Hide();
            }
        }

        private void radio_email_MouseEnter(object sender, EventArgs e)
        {
            radio_email.ForeColor = Color.Gray;
        }

        private void radio_email_MouseLeave(object sender, EventArgs e)
        {
            radio_email.ForeColor = Color.White;
        }

        private void radio_nom_MouseEnter(object sender, EventArgs e)
        {
            radio_nom.ForeColor = Color.Gray;
        }

        private void radio_nom_MouseLeave(object sender, EventArgs e)
        {
            radio_nom.ForeColor = Color.White;
        }
    }
}
