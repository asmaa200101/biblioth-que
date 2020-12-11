using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_sabour
{
    public partial class Adherent : Form
    {
        public Adherent()
        {
            InitializeComponent();
        }
        SqlCommand command = new SqlCommand();
        SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=BIBLIO;Integrated Security=True");
        DataTable dt = new DataTable();
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Adherent_Load(object sender, EventArgs e)
        {
            cn.Open();
            command = new SqlCommand("select * from livre", cn);
            dt.Load(command.ExecuteReader());
            label1.Text = dt.Rows[0]["titre"].ToString() ;
            label2.Text = dt.Rows[0]["auteur"].ToString();
            label3.Text = dt.Rows[0]["description"].ToString();
            byte[] a = (byte[])(dt.Rows[0]["image"]);
            MemoryStream ms = new MemoryStream(a);
            panel3.BackgroundImage = Image.FromStream(ms);
            ms.Close();
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel9.Hide();
        }
    }
}
