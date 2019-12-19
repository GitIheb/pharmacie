using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.OleDb;

namespace DAL
{
    public class utilisateurDAO
    {
        public static bool Insert_client(string nom, string prenom,  string fonction, string mail)
        {
            string requete = String.Format("insert into utilisateur(nom,  prenom, fonction,mail)" +
                " values ('{0}','{1}','{2}','{3}');", nom,prenom,fonction, mail);
            return utils.miseajour(requete);
        }


        public static bool Update_client(int id ,string nom, string prenom,string password , string fonction, string mail)
        {
            string requete = String.Format("update utilisateur set nom='{0}', prenom='{1}'," +
                " password='{2}' ,fonction='{3}',mail='{4}' where id={5};", nom, prenom,password, fonction, mail, id);
            return utils.miseajour(requete);
        }


        public static bool Delete_client(int id)
        {
            string requete = String.Format("delete from utilisateur where id={0};", id);
            return utils.miseajour(requete);
        }


        public static utilisateur Get_login_ID(int id)
        {
            string requete = String.Format("select id, nom , prenom , mail from utilisateur where id={0};", id);
            OleDbDataReader rd = utils.lire(requete);
            utilisateur c = new utilisateur();
            while (rd.Read())
            {
                c.Id = rd.GetInt32(0);
                c.Nom= rd.GetString(1);
                c.Prenom = rd.GetString(2);
                c.Mail = rd.GetString(3);
            }
            utils.Disconnect();
            return c;
        }


        public static string verif_client(string nm, string pass)
        {
            string v = "no";
            string requete = String.Format("select nom , password , fonction from utilisateur where nom='{0}' ", nm);
            OleDbDataReader rd = utils.lire(requete);
            while (rd.Read())
            {
                if (rd.GetString(0) == nm && rd.GetString(1) == pass && rd.GetString(2) == "client")
                {
                    v = "client";
                }
                else if (rd.GetString(0) == nm && rd.GetString(1) == pass && (rd.GetString(2) == "pharmacien" || rd.GetString(2) == "employé"))
                {
                    v = "phar";
                }

            }
            utils.Disconnect();
            return v;
        }


        public static string verif_date()
        {
            string  T = "no";
            int idd;
      
            string requete = String.Format("select id ,nom_med from médicament where NOW() > date_pere ;");
            OleDbDataReader rd = utils.lire(requete);
            while (rd.Read())
            {
                    idd = rd.GetInt32(0);
                    T = rd.GetString(1);
          
            }     
                string req = String.Format("delete  from médicament where NOW() > date_pere ");
                utils.miseajour(req);
            utils.Disconnect();
            return T;
        }


        public static List<utilisateur> Get_login()
        {
            string requete = String.Format("select id, nom , prenom, mail from utilisateur where fonction ='client';");
            OleDbDataReader rd = utils.lire(requete);
            List<utilisateur> L = new List<utilisateur>();
            utilisateur c;
            while (rd.Read())
            {
                c = new utilisateur
                {
                    Id = rd.GetInt32(0),
                    Nom = rd.GetString(1),
                    Prenom = rd.GetString(2),
                    Mail= rd.GetString(3)
                };
                L.Add(c);
            }
            utils.Disconnect();
            return L;
        }
    }
}
