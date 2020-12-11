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
    public partial class ajout_adh : UserControl
    {
        public ajout_adh()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void ajout_adh_Load(object sender, EventArgs e)
        {
           
            cn.Open();
            command = new SqlCommand("select libellé from profession", cn);
            dt.Load(command.ExecuteReader());
            cmb_profession.DataSource = dt;
            cmb_profession.ValueMember = "libellé";
            cn.Close();
           
        
    }
        public static string random_string()
        {
            string dico = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[6];
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                chars[i] = dico[rand.Next(0, dico.Length)];
            }

            return new string(chars);
        }
        
        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            cn.Open();
            string passeword = random_string();
            command = new SqlCommand("ajouter_adherents", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nom", txt_nom.Text);
            command.Parameters.AddWithValue("@prenom", txt_prenom.Text);
            command.Parameters.AddWithValue("@cin", txt_cin.Text);
            command.Parameters.AddWithValue("@adresse", txt_adresse.Text);
            command.Parameters.AddWithValue("@tel", txt_tel.Text);
            command.Parameters.AddWithValue("@email", txt_email.Text);
            command.Parameters.AddWithValue("@profession", cmb_profession.SelectedValue);
            command.Parameters.AddWithValue("@passeword", passeword);
            SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
            test.Direction = ParameterDirection.Output;
            command.ExecuteScalar();
            if (test.Value.ToString() == "0")
            {
                MessageBox.Show("vous avez ajouter l'adhérent avec succés");
            }
            else
            {
                MessageBox.Show("l'adérent a déjà un compte");
            }
            cn.Close();
        }

        private void btn_initialiser_Click(object sender, EventArgs e)
        {
            txt_adresse.Text = txt_cin.Text = txt_email.Text = txt_nom.Text = txt_prenom.Text = txt_tel.Text = "";
        }
    }
}
