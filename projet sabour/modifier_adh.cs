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
    public partial class modifier_adh : UserControl
    {
        public modifier_adh()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIOTHEQUE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void btn_modifier_adh_Click(object sender, EventArgs e)
        {

            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("modifier_adherent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nom", nom_m.Text);
            command.Parameters.AddWithValue("@prenom", prenom_m.Text);
            command.Parameters.AddWithValue("@cin", cin_m.Text);
            command.Parameters.AddWithValue("@adresse", adresse_m.Text);
            command.Parameters.AddWithValue("@tel", tel_m.Text);
            command.Parameters.AddWithValue("@email", email_m.Text);
            command.Parameters.AddWithValue("@profession", profession_m.SelectedValue);
            SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
            test.Direction = ParameterDirection.Output;
            command.ExecuteScalar();
            cn.Close();
            if (test.Value.ToString() == "0")
            {
                MessageBox.Show("vous avez modifier les information de l'adhérent avec succés");
            }
            else
            {
                MessageBox.Show("l'adérent n'existe pas");
            }
            
        }

        private void modifier_adh_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select libellé from profession", cn);
            dt.Load(command.ExecuteReader());
            profession_m.DataSource = dt;
            profession_m.ValueMember = "libellé";
            cn.Close();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command =new SqlCommand("select * from adherents where email like '"+email_m.Text+"'",cn);
            SqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                cin_m.Text = dr["cin"].ToString();
                nom_m.Text = dr["nom"].ToString();
                prenom_m.Text = dr["prenom"].ToString();
                adresse_m.Text = dr["adresse"].ToString();
                profession_m.Text = dr["profession"].ToString();
                tel_m.Text = dr["tél"].ToString();
            }
            else
            {
                MessageBox.Show("l'email n'existe pas veuillez verifier");
            }
            cn.Close();
            btn_modifier_adh.Show();
            groupBox1.Show();
            groupBox2.Show();

        }
    }
}
