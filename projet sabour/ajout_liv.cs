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
using System.IO;

namespace projet_sabour
{
    public partial class ajout_liv : UserControl
    {
        public ajout_liv()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void btn_initialiser_Click(object sender, EventArgs e)
        {
            txt_auteur.Text = txt_code.Text = txt_description.Text = txt_nb.Text = txt_titre.Text = "";
            
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(f.FileName);
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            image.Image.Save(ms, image.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("ajouter_livre", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@code", txt_code.Text);
            command.Parameters.AddWithValue("@auteur", txt_auteur.Text);
            command.Parameters.AddWithValue("@titre", txt_titre.Text);
            command.Parameters.AddWithValue("@nb", txt_nb.Text);
            command.Parameters.AddWithValue("@description", txt_description.Text);
            command.Parameters.AddWithValue("@code_th", cmb_theme.SelectedValue);
            command.Parameters.AddWithValue("@image", a);
            SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
            test.Direction = ParameterDirection.Output;
            command.ExecuteScalar();
            cn.Close();
            if (test.Value.ToString() == "0")
            {
                MessageBox.Show("vous avez ajouter la livre avec succés");
            }
            else
            {
                MessageBox.Show("le livre existe déjà");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_theme.Visible=true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel_theme.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (cn.State == ConnectionState.Closed)
                { cn.Open(); }
                command = new SqlCommand("insert into themes (intitulé) values('" + textBox1.Text + "')", cn);
                command.ExecuteScalar();
                cn.Close();
                textBox1.Clear();
                panel_theme.Visible=false;
                
                ajout_liv_Load(sender, e);
            }
            else
            {
                MessageBox.Show("veuillez tapper le théme svp");
            }
        }

        private void ajout_liv_Load(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select * from themes", cn);
            dt = new DataTable();
            dt.Load(command.ExecuteReader());
            cmb_theme.DataSource = dt;
            cmb_theme.ValueMember = "id";
            cmb_theme.DisplayMember = "intitulé";
            cn.Close();
        }

        private void cmb_theme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
