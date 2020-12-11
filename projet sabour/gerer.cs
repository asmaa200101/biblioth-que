using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projet_sabour
{
    public partial class gerer : Form
    {
        public gerer()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_livre_MouseLeave(object sender, EventArgs e)
        {
            btn_livre.ForeColor = Color.White;
        }
        private void btn_livre_MouseEnter(object sender, EventArgs e)
        {
            btn_livre.ForeColor = Color.DimGray;
            hidepanel();
            showpanel(panel_livre);
        }
        private void btn_adherent_MouseEnter(object sender, EventArgs e)
        {
            btn_adherent.ForeColor = Color.DimGray;
            hidepanel();
            showpanel(panel_adherent);
        }

        private void btn_adherent_MouseLeave(object sender, EventArgs e)
        {
            btn_adherent.ForeColor = Color.White;
           
        }
        private void btn_exemplaire_MouseEnter(object sender, EventArgs e)
        {
            btn_exemplaire.ForeColor = Color.DimGray;
            hidepanel();
            showpanel(panel_exemplaire);
        }

        private void btn_exemplaire_MouseLeave(object sender, EventArgs e)
        {
            btn_exemplaire.ForeColor = Color.White;
            
        }

        private void btn_emprunt_MouseEnter(object sender, EventArgs e)
        {
            btn_emprunt.ForeColor = Color.DimGray;
            
        }

        private void btn_emprunt_MouseLeave(object sender, EventArgs e)
        {
            hidepanel();
            btn_emprunt.ForeColor = Color.White;
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void hidepanel()
        {
            if (panel_adherent.Visible == true)
                panel_adherent.Visible = false;
            if (panel_exemplaire.Visible == true)
                panel_exemplaire.Visible = false;
            if (panel_livre.Visible == true)
                panel_livre.Visible = false;
        }
        void showpanel(Panel p)
        {
            if (p.Visible == false)
            {
                hidepanel();
                p.Visible = true;
            }
            else
                p.Visible = false;
        }
        private void btn_adherent_Click(object sender, EventArgs e)
        {
            if(panel_adherent.Visible)
            {
                hidepanel();
            }
            else
            showpanel(panel_adherent);
        }

        private void btn_livre_Click(object sender, EventArgs e)
        {
            if (panel_livre.Visible)
            {
                hidepanel();
            }
            else
                showpanel(panel_livre);
        }

        private void btn_suppression_exm_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void btn_modification_exm_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void btn_recherche_exm_Click(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void btn_ajout_exm_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new ajout_exemplaire());
        }

        private void btn_modification_adh_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new modifier_adh());
        }

        private void btn_suppression_adh_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new supprimer_adh());
        }

        private void btn_recherche_adh_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new rechercher_adh());
        }

        private void btn_ajout_adh_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new ajout_adh());
        }

        private void btn_modification_liv_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new modifier_liv());
        }

        private void btn_suppression_liv_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new supprimer_liv());
        }

        private void btn_recherche_liv_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new reherche_liv());
        }
        
        private void btn_ajout_liv_Click(object sender, EventArgs e)
        {
            hidepanel();
            panel_child.Controls.Clear();
            panel_child.Controls.Add(new ajout_liv());
        }

        private void btn_exemplaire_Click(object sender, EventArgs e)
        {
            if (panel_adherent.Visible)
            {
                hidepanel();
            }
            else
                showpanel(panel_exemplaire);
        }

        private void btn_ajout_liv_MouseEnter(object sender, EventArgs e)
        {
            btn_ajout_liv.ForeColor = Color.Maroon;
        }

        private void btn_ajout_liv_MouseLeave(object sender, EventArgs e)
        {
            btn_ajout_liv.ForeColor = Color.White;
        }

        private void btn_recherche_liv_MouseLeave(object sender, EventArgs e)
        {
            btn_recherche_liv.ForeColor = Color.White;
        }

        private void btn_recherche_liv_MouseEnter(object sender, EventArgs e)
        {
            btn_recherche_liv.ForeColor = Color.Maroon;
        }

        private void btn_suppression_liv_MouseEnter(object sender, EventArgs e)
        {
            btn_suppression_liv.ForeColor = Color.Maroon;
        }

        private void btn_suppression_liv_MouseLeave(object sender, EventArgs e)
        {
            btn_suppression_liv.ForeColor = Color.White;
        }

        private void btn_modification_liv_MouseEnter(object sender, EventArgs e)
        {
            btn_modification_liv.ForeColor = Color.Maroon;
        }

        private void btn_ajout_adh_MouseEnter(object sender, EventArgs e)
        {
            btn_ajout_adh.ForeColor = Color.Maroon;
        }
        private void btn_ajout_adh_MouseLeave(object sender, EventArgs e)
        {
            btn_ajout_adh.ForeColor = Color.White;
        }

        private void btn_recherche_adh_MouseLeave(object sender, EventArgs e)
        {
            btn_recherche_adh.ForeColor = Color.White;
        }

        private void btn_recherche_adh_MouseEnter(object sender, EventArgs e)
        {
            btn_recherche_adh.ForeColor = Color.Maroon;
        }

        private void btn_suppression_adh_MouseEnter(object sender, EventArgs e)
        {
            btn_suppression_adh.ForeColor = Color.Maroon;
        }

        private void btn_suppression_adh_MouseLeave(object sender, EventArgs e)
        {
            btn_suppression_adh.ForeColor = Color.White;
        }

        private void btn_modification_adh_MouseEnter(object sender, EventArgs e)
        {
            btn_modification_adh.ForeColor = Color.Maroon;
        }

        private void btn_modification_adh_MouseLeave(object sender, EventArgs e)
        {
            btn_modification_adh.ForeColor = Color.White;
        }

        private void btn_modification_liv_MouseLeave(object sender, EventArgs e)
        {
            btn_modification_liv.ForeColor = Color.White;
        }
        private void btn_ajout_exm_MouseEnter(object sender, EventArgs e)
        {
            btn_ajout_exm.ForeColor = Color.Maroon;
        }
        private void btn_ajout_exm_MouseLeave(object sender, EventArgs e)
        {
            btn_ajout_exm.ForeColor = Color.White;
        }

        private void btn_recherche_exm_MouseLeave(object sender, EventArgs e)
        {
            btn_recherche_exm.ForeColor = Color.White;
        }

        private void btn_recherche_exm_MouseEnter(object sender, EventArgs e)
        {
            btn_recherche_exm.ForeColor = Color.Maroon;
        }

        private void btn_suppression_exm_MouseEnter(object sender, EventArgs e)
        {
            btn_suppression_exm.ForeColor = Color.Maroon;
        }

        private void btn_suppression_exm_MouseLeave(object sender, EventArgs e)
        {
            btn_suppression_exm.ForeColor = Color.White;
        }

        private void btn_modification_exm_MouseEnter(object sender, EventArgs e)
        {
            btn_modification_exm.ForeColor = Color.Maroon;
        }

        private void btn_modification_exm_MouseLeave(object sender, EventArgs e)
        {
            btn_modification_exm.ForeColor = Color.White;
        }

        private void gerer_Load(object sender, EventArgs e)
        {

        }

        private void gerer_MouseEnter(object sender, EventArgs e)
        {
            hidepanel();
        }

        private void btn_emprunt_Click(object sender, EventArgs e)
        {

        }
    }
}
