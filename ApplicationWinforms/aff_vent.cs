using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BEL;
using DAL;

namespace ApplicationWinforms
{
    public partial class aff_vent : Form
    {
        public aff_vent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<vente> Listvent = venteDAO.Get_vent();
                grid_vent.DataSource = Listvent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               vente v = venteDAO.Get_vent_ID(int.Parse(tbID.Text));
                tbprod.Text = v.Produit;
                tbqt.Text = (v.Quantite).ToString();
                tbmont.Text = (v.montant_tot).ToString();
                textdate.Text = (v.date_v).ToString();
                List<vente> L = new List<vente>();
                L.Add(v);
                grid_vent.DataSource = L;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                venteDAO.Delete_vent(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
