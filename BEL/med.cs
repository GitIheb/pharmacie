using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class med
    {
        public int Id { get; set; }
        public int ref_med { get; set; }
        public string categorie { get; set; }
        public string nom_med { get; set; }
        public string disponibilité { get; set; }
        public int prix { get; set; }
        public int qte_stock { get; set; }
    }
}
