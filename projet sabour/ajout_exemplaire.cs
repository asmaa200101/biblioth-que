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
    public partial class ajout_exemplaire : UserControl
    {
        public ajout_exemplaire()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand();
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        DataTable dt = new DataTable();
        private void ajout_exemplaire_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select * from livre", cn);
            dt = new DataTable();
            dt.Load(command.ExecuteReader());
            cmb_livre.DataSource = dt;
            cmb_livre.ValueMember = "code";
            cmb_livre.DisplayMember = "Titre";
            cn.Close();
        }

        private void btn_initialiser_Click(object sender, EventArgs e)
        {
            txt_code.Text = txt_etat.Text = cmb_livre.Text = date_edition.Text = "";
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

        }
    }
}
