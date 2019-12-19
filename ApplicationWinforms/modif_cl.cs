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
    public partial class modif_cl : Form
    {
        public modif_cl()
        {
            InitializeComponent();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                utilisateurDAO.Update_client(int.Parse(txt_id.Text), txt_nom.Text, txt_prenom.Text,maskedTextBox1.Text,maskedTextBox2.Text ,txt_mail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            affich_cl frm = new affich_cl();
            frm.Show();
        }
    }
}
