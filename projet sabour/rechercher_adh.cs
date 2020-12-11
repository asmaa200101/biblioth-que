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
    public partial class rechercher_adh : UserControl
    {
        public rechercher_adh()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIOTHEQUE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void check_cin_MouseEnter(object sender, EventArgs e)
        {
            check_cin.ForeColor = Color.Gray;
        }

        private void check_cin_MouseLeave(object sender, EventArgs e)
        {
            check_cin.ForeColor = Color.White;
        }

        

        private void check_nom_MouseEnter(object sender, EventArgs e)
        {
            check_nom.ForeColor = Color.Gray;
        }

        private void check_nom_MouseLeave(object sender, EventArgs e)
        {
            check_nom.ForeColor = Color.White;
        }

        private void check_email_MouseEnter(object sender, EventArgs e)
        {
            check_email.ForeColor = Color.Gray;
        }

        private void check_email_MouseLeave(object sender, EventArgs e)
        {
            check_email.ForeColor = Color.White;
        }

        private void check_profession_MouseEnter(object sender, EventArgs e)
        {
            check_profession.ForeColor = Color.Gray;
        }

        private void check_profession_MouseLeave(object sender, EventArgs e)
        {
            check_profession.ForeColor = Color.White;
        }

        private void check_cin_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cin.Checked)
            {
                cin_rech.Show();
            }
            else
            {
                cin_rech.Clear();
                cin_rech.Hide();
            }
        }

        private void check_nom_CheckedChanged(object sender, EventArgs e)
        {
            if (check_nom.Checked)
            {
                nom_rech.Show();
            }
            else
            {
                nom_rech.Clear();
                nom_rech.Hide();
            }
        }
        private void check_email_CheckedChanged(object sender, EventArgs e)
        {
            if (check_email.Checked)
            {
                email_rech.Show();
            }
            else
            {
                email_rech.Clear();
                email_rech.Hide();
            }
        }
        private void check_profession_CheckedChanged(object sender, EventArgs e)
        {
            if (check_profession.Checked)
            {
                profession_rech.Show();
            }
            else
            {
                profession_rech.Hide();
            }
        }
  
        private void cin_rech_TextChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            string cm = "select * from adherents where 1=1";
            if (check_cin.Checked)
            {
                cm += " and cin like '" + cin_rech.Text + "%'";
            }
            if (check_email.Checked)
            {
                cm += " and email like '" + email_rech.Text + "%'";
            }
            if (check_nom.Checked)
            {
                cm += " and nom like '" + nom_rech.Text + "%'";
            }
            if (check_profession.Checked)
            {
                cm += " and profession like '" + profession_rech.SelectedValue + "'";
            }
            command = new SqlCommand(cm, cn);
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            dr = command.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void email_rech_TextChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            string cm = "select * from adherents where 1=1";
            if (check_cin.Checked)
            {
                cm += " and cin like '" + cin_rech.Text + "%'";
            }
            if (check_email.Checked)
            {
                cm += " and email like '" + email_rech.Text + "%'";
            }
            if (check_nom.Checked)
            {
                cm += " and nom like '" + nom_rech.Text + "%'";
            }
            if (check_profession.Checked)
            {
                cm += " and profession like '" + profession_rech.SelectedValue + "'";
            }
            command = new SqlCommand(cm, cn);
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            dr = command.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void profession_rech_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            string cm = "select * from adherents where 1=1";
            if (check_cin.Checked)
            {
                cm += " and cin like '" + cin_rech.Text + "%'";
            }
            if (check_email.Checked)
            {
                cm += " and email like '" + email_rech.Text + "%'";
            }
            if (check_nom.Checked)
            {
                cm += " and nom like '" + nom_rech.Text + "%'";
            }
            if (check_profession.Checked)
            {
                cm += " and profession like '" + profession_rech.SelectedValue + "'";
            }
            command = new SqlCommand(cm, cn);
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            dr = command.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        SqlDataReader dr;
        private void nom_rech_TextChanged(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            string cm = "select * from adherents where 1=1";
            if (check_cin.Checked)
            {
                cm += " and cin like '" + cin_rech.Text + "%'";
            }
            if (check_email.Checked)
            {
                cm += " and email like '" + email_rech.Text + "%'";
            }
            if (check_nom.Checked)
            {
                cm += " and nom like '" + nom_rech.Text + "%'";
            }
            if (check_profession.Checked)
            {
                cm += " and profession like '" + profession_rech.SelectedValue + "'";
            }
            command = new SqlCommand(cm, cn);
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            dr = command.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void rechercher_adh_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select libellé from profession", cn);
            SqlDataReader dr = command.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            profession_rech.DataSource = dt;
            profession_rech.ValueMember = "libellé";
            cn.Close();
        }
    }
}
