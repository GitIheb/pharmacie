using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class vente
    {
        public int Id { get; set; }
        public string Produit { get; set; }
        public int Quantite { get; set; }
        public int montant_tot { get; set; }
        public DateTime date_v { get; set; }
    }
}
