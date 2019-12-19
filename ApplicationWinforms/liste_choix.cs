using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationWinforms
{
    public partial class liste_choix : Form
    {
        public liste_choix()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           aff_med frm = new aff_med();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            affich_cl frm = new affich_cl();
            frm.Show();
        }

        private void ventes_Click(object sender, EventArgs e)
        {

            aff_vent frm = new aff_vent();
            frm.Show();

        }
    }
}
