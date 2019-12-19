using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;

namespace ApplicationWinforms
{
    public partial class ajout_cl : Form
    {
        public ajout_cl()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            affich_cl frm = new affich_cl();
            frm.Show();
        }

        private void ajout_Click(object sender, EventArgs e)
        {

            try
            {
                utilisateurDAO.Insert_client(tex_nom.Text, text_pre.Text, maskedTextBox1.Text, text_mail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            affich_cl frm = new affich_cl();
            frm.Show();
        }
    }
}
