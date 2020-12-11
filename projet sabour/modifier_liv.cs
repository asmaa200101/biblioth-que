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
    public partial class modifier_liv : UserControl
    {
        public modifier_liv()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        DataTable dt = new DataTable();
        private void btn_afficher_Click(object sender, EventArgs e)
        {
            if (cn.State == ConnectionState.Closed)
            { cn.Open(); }
            command = new SqlCommand("select * from livre where code='" + txt_code.Text+"'" , cn);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                txt_auteur.Text = dr["auteur"].ToString();
                txt_code.Text = dr["code"].ToString();
               txt_description.Text = dr["description"].ToString();
                txt_nb.Text = dr["qte_stock"].ToString();
                txt_titre.Text = dr["titre"].ToString();
                cmb_theme.SelectedValue = dr["theme"];
                byte[]a = (byte[])(dr["image"]);
                MemoryStream ms = new MemoryStream(a);
                image.Image = Image.FromStream(ms);
                ms.Close();
            groupBox1.Show();
            groupBox2.Show();
            btn_modifier.Show();
               
            }
            else
            {
                MessageBox.Show("le livre n'existe pas veuillez verifier");
            }
            cn.Close();
            

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            image.Image.Save(ms, image.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
            if (cn.State == ConnectionState.Closed)
                { cn.Open(); }
                command = new SqlCommand("modifier_livre", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@auteur", txt_auteur.Text);
                command.Parameters.AddWithValue("@code", txt_code.Text);
                command.Parameters.AddWithValue("@titre", txt_titre.Text);
                command.Parameters.AddWithValue("@nb", txt_nb.Text);
                command.Parameters.AddWithValue("@description", txt_description.Text);
                command.Parameters.AddWithValue("@code_th", cmb_theme.SelectedValue);
                command.Parameters.AddWithValue("@image", a);
                SqlParameter test = command.Parameters.Add("@error", SqlDbType.Int);
                test.Direction = ParameterDirection.Output;
                command.ExecuteScalar();
                cn.Close();
                if (int.Parse(test.Value.ToString()) >0)
                {
                    MessageBox.Show("vous avez modifier les information de la livre avec succés");
                }
                else
                {
                    MessageBox.Show("le livre n'existe pas");
                }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg|all files(*.*)|*.*";
            if(f.ShowDialog()==DialogResult.OK)
            {
                image.Image = Image.FromFile(f.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_theme.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel_theme.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                if (cn.State == ConnectionState.Closed)
                { cn.Open(); }
                command = new SqlCommand("insert into themes (intitulé) values('" + textBox1.Text + "')",cn);
                command.ExecuteScalar();
                cn.Close();
                textBox1.Clear();
                panel_theme.Hide();
                cmb_theme.Items.Clear();
                modifier_liv_Load(sender, e);
            }
            else
            {
                MessageBox.Show("veuillez tapper le théme svp");
            }
        }

        private void modifier_liv_Load(object sender, EventArgs e)
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
    }
}
