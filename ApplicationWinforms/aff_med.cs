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
    public partial class aff_med : Form
    {
        public aff_med()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<med> Listmed = medDAO.Get_med();
                grid_med.DataSource = Listmed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                med md = medDAO.Get_med_ID(int.Parse(tbID.Text));
                ref_med.Text = (md.ref_med).ToString();
                categorie.Text = md.categorie;
                nom_med.Text = md.nom_med;
                prix.Text = (md.prix).ToString();
                dispo.Text = md.disponibilité;
                qte.Text = (md.qte_stock).ToString();
                List<med> L = new List<med>();
                L.Add(md);
                grid_med.DataSource = L; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                medDAO.Delete_med(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
