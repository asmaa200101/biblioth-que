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
    public partial class reherche_liv : UserControl
    {
        public reherche_liv()
        {
            InitializeComponent();
        }
        void affichage()
        {
            if(check_titre.Checked)
            {
                txt_titre.Visible = true;
            }
            else
            {
                txt_titre.Visible = false;
            }
            if (check_theme.Checked)
            {
                cmb_theme.Visible = true;
            }
            else
            {
                cmb_theme.Visible = false;
            }
            if (check_auteur.Checked)
            {
                txt_auteur.Visible = true;
            }
            else
            {
                txt_auteur.Visible = false;
            }
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void reherche_liv_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select * from themes", cn);
            dt.Load(command.ExecuteReader());
            cmb_theme.DataSource = dt;
            cmb_theme.ValueMember = "id";
            cmb_theme.DisplayMember = "intitulé";
            cn.Close();
        }

        private void check_titre_Click(object sender, EventArgs e)
        {
            affichage();
        }

        private void check_titre_MouseEnter(object sender, EventArgs e)
        {
            check_titre.ForeColor = Color.DimGray;
        }

        private void check_titre_MouseLeave(object sender, EventArgs e)
        {
            check_titre.ForeColor = Color.White;
        }

        private void check_auteur_MouseEnter(object sender, EventArgs e)
        {
            check_auteur.ForeColor = Color.DimGray;
        }

        private void check_auteur_MouseLeave(object sender, EventArgs e)
        {
            check_auteur.ForeColor = Color.White;
        }

        private void check_theme_MouseEnter(object sender, EventArgs e)
        {
            check_theme.ForeColor = Color.DimGray;
        }

        private void check_theme_MouseLeave(object sender, EventArgs e)
        {
            check_theme.ForeColor = Color.White;
        }
        void recherche()
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            string cm = "select * from livre where 1=1";
            if (check_titre.Checked)
            {
                cm += " and titre like '" + txt_titre.Text + "%'";
            }
            if(check_theme.Checked)
            {
                cm += " and theme = " + cmb_theme.SelectedValue;
            }
            if(check_auteur.Checked)
            {
                cm += " and auteur like '" + txt_auteur.Text + "%'";
            }
            command = new SqlCommand(cm, cn);
            dt = new DataTable();
            dt.Load(command.ExecuteReader());
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void txt_titre_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }

        private void txt_auteur_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }

        private void cmb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherche();
        }
    }
}
