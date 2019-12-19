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
using System.Data.OleDb;
namespace ApplicationWinforms
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }
        string b;
        string R;
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
               b = utilisateurDAO.verif_client(name.Text, password.Text);
               R = utilisateurDAO.verif_date();
                if (b == "client")
                { 
                    list_vent frm = new list_vent();
                    frm.Show();
                }
                else if(b == "phar")
                {
                 if(R!= "no")
                    { MessageBox.Show("le medicament "+R+" est expiré"); }

                    liste_choix frm = new liste_choix();
                    frm.Show();
                }
                else

                {
                    MessageBox.Show("login or password invalide ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ajout_cl form = new ajout_cl();
            form.Show();
        }
    }
}



        