using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;

namespace ApplicationWinforms
{

    public partial class affich_cl : Form
    {
        public affich_cl()
        {
            InitializeComponent();
        }
        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ajout_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                utilisateur clt = utilisateurDAO.Get_login_ID(int.Parse(tbID.Text));
                tbnom.Text = clt.Nom;
                tbprenom.Text = clt.Prenom;
                tbmail.Text = clt.Mail;
                List<utilisateur> L = new List<utilisateur>();
                L.Add(clt);
                grid_clients.DataSource = L;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<utilisateur> ListClients = utilisateurDAO.Get_login();
                grid_clients.DataSource = ListClients;
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
              utilisateurDAO.Delete_client(int.Parse(txt_ID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            modif_cl form = new modif_cl();
            form.Show();
        }

        private void grid_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
