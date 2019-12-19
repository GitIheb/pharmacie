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
    public partial class modif_med : Form
    {
        public modif_med()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              medDAO.Update_med(int.Parse(txt_id.Text), txt_ref.Text , txt_catg.Text, nomed.Text, int.Parse(prix.Text) , disp.Text, int.Parse(qte.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aff_med frm = new aff_med();
            frm.Show();
        }
    }
}
