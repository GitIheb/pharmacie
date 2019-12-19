using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class medDAO
    {

        public static bool Insert_med(string categorie, string nom_med, int prix, string disponibilité, int qte_stock)
        {
            string requete = String.Format("insert into médicament(categorie,  nom_med, prix, disponibilité, qte_stock)" +
                " values ('{0}','{1}','{2}','{3}','{4}');", categorie, nom_med, prix, disponibilité, qte_stock);
            return utils.miseajour(requete);
        }

        public static bool Update_med(int id,string ref_med, string categorie, string nom_med, int prix, string disponibilité, int qte_stock)
        {
            string requete = String.Format("update médicament set ref_med='{0}', categorie='{1}'," +
                " nom_med='{2}' ,prix='{3}',disponibilité='{4}',qte_stock='{5}' where id={6};", ref_med ,categorie, nom_med, prix, disponibilité, qte_stock, id);
            return utils.miseajour(requete);
        }

        public static bool Delete_med(int id)
        {
            string requete = String.Format("delete from médicament where id={0};", id);
            return utils.miseajour(requete);
        }

        public static med Get_med_ID(int id)
        {
            string requete = String.Format("select * from médicament where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            med c = new med();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.ref_med = rd.GetInt32(1);
                c.categorie = rd.GetString(2);
                c.nom_med = rd.GetString(3);
                c.prix = rd.GetInt32(4);
                c.disponibilité = rd.GetString(5);
                c.qte_stock = rd.GetInt32(6);
            }
            utils.Disconnect();
            return c;
        }

        public static List<med> Get_med()
        {
            string requete = String.Format("select * from médicament;");
            OleDbDataReader rd = utils.lire(requete);
            List<med> L = new List<med>();
            med m;
            while (rd.Read())
            {
                m = new med
                {
                    Id = rd.GetInt32(0),
                    ref_med = rd.GetInt32(1),
                    categorie = rd.GetString(2),
                    nom_med = rd.GetString(3),
                    prix = rd.GetInt32(4),
                    disponibilité = rd.GetString(5),
                    qte_stock = rd.GetInt32(6)
                };
                L.Add(m);
            }
            utils.Disconnect();
            return L;
        }

    }
}
