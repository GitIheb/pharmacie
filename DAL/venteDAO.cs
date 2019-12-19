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
   public class venteDAO
    {
        public static bool Insert_vent(string Produit, int Quantite, int montant_tot, DateTime date_v)
        {
            string requete = String.Format("insert into vente(Produit,Quantite, montant_tot, date_v)" +
                " values ('{0}','{1}','{2}','{3}');", Produit, Quantite, montant_tot, date_v);
            return utils.miseajour(requete);
        }
   
        public static bool Update_vent(int id, string Produit, int Quantite, int montant_tot, DateTime date_v)
        {
        string requete = String.Format("update vente set Produit='{0}', Quantite='{1}'," +
            " montant_tot='{2}' ,date_v='{3}' where id={4};", Produit, Quantite, montant_tot, date_v, id);
        return utils.miseajour(requete);
        }
        public static bool Delete_vent(int id)
        {
            string requete = String.Format("delete from vente where id={0};", id);
            return utils.miseajour(requete);
        }
        public static vente Get_vent_ID(int id)
        {
            string requete = String.Format("select * from vente where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            vente v = new vente();
            while (rd.Read())
            {
                v.Id = rd.GetInt32(0);
                v.Produit = rd.GetString(1);
                v.Quantite = rd.GetInt32(2);
                v.montant_tot = rd.GetInt32(3);
                v.date_v = rd.GetDateTime(4);
           
            }
            utils.Disconnect();
            return v;
        }

        public static List<vente> Get_vent()
        {
            string requete = String.Format("select * from vente;");
            OleDbDataReader rd = utils.lire(requete);
            List<vente> L = new List<vente>();
            vente v;
            while (rd.Read())
            {
                v= new vente
                {
                Id = rd.GetInt32(0),
                Produit = rd.GetString(1),
                Quantite = rd.GetInt32(2),
                montant_tot = rd.GetInt32(3),
                date_v = rd.GetDateTime(4)
            };
                L.Add(v);
            }
            utils.Disconnect();
            return L;
        }
        public static List<vente> Get_vent_client(int id)
        {
            string requete = String.Format("select * from vente where id_client={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            List<vente> L = new List<vente>();
            vente v;
            while (rd.Read())
            {
                v = new vente
                {
                    Id = rd.GetInt32(0),
                    Produit = rd.GetString(1),
                    Quantite = rd.GetInt32(2),
                    montant_tot = rd.GetInt32(3),
                    date_v = rd.GetDateTime(4)
                };
                L.Add(v);
            }
            utils.Disconnect();
            return L;
        }
    }
}
