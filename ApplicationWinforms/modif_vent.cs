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
    public partial class modif_vent : Form
    {
        public modif_vent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               venteDAO.Update_vent(int.Parse(txt_id.Text), txt_prod.Text, int.Parse(txt_qt.Text), int.Parse(txt_mnt.Text), DateTime.Parse(date.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aff_vent frm = new aff_vent();
            frm.Show();
        }
    }
}
