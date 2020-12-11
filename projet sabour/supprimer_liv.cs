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
    public partial class supprimer_liv : UserControl
    {
        public supprimer_liv()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supprimer_liv_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select * from livre", cn);
            dt.Load(command.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "code";
            comboBox1.DisplayMember = "code";
            cn.Close();
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("supprimer_livre", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@code", comboBox1.SelectedValue);
            SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
            test.Direction = ParameterDirection.Output;
            DialogResult resultat= MessageBox.Show("est ce que tu veut supprimer le livre", "Livre", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                command.ExecuteScalar();
                if (test.Value.ToString() == "0")
                {
                    MessageBox.Show("vous avez supprimer le livre avec succés");
                }
                else
                {
                    MessageBox.Show("le livre n'existe pas");
                }
            }
           
            cn.Close();
        }
    }
}
