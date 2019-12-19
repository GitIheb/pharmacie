using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using DAL;
using System.Data.OleDb;

namespace ApplicationWinforms
{
    public partial class ajout_med : Form
    {
        public ajout_med()
        {
            InitializeComponent();
        }

        private void ajout_Click(object sender, EventArgs e)
        {  

            try
            {
               medDAO.Insert_med(ref_med.Text, nom_med.Text, int.Parse(maskedTextBox2.Text), maskedTextBox1.Text, int.Parse(maskedTextBox3.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
