using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Objects;

namespace TestApp.DB
{

    class DBMethods
    {

        DataClasses1DataContext dat = new DataClasses1DataContext();

        IQueryable<tbl_Proprio> custQuery;

        public IQueryable<tbl_Proprio> CustQuery
        {
            get { return custQuery; }
            set { custQuery = value; }
        }


        public OleDbDataReader testACCESS()
        {
                OleDbConnection conn = null;
                OleDbDataReader reader = null;
                try
                {
                    conn = new OleDbConnection(
                        "Provider=Microsoft.Jet.OLEDB.4.0; " + 
                        "Data Source=" + "C:/Users/Negers/Desktop/Prog Dadou/BDD/BaseTMT 13022014.mdb");//+ Server.MapPath("Pets/Pets.mdb"));
                    conn.Open();

                    OleDbCommand cmd =
                        new OleDbCommand("SELECT ID_Pro, Titre, Prenom, Nom_Pro,Nom_p2, NumRuePro, TypeRuePro,RueProp, CodePostalPro, VillePro, Tel,TaxeFonc FROM tbl_Proprio", conn);
                    reader = cmd.ExecuteReader();
                }
//        catch (Exception e)
//        {
//            Response.Write(e.Message);
//            Response.End();
//        }
                finally
                {
                    
                    //if (reader != null)  reader.Close();
                    //if (conn != null)  conn.Close();
                }
                return reader;
        }

        //public ObservableCollection<Proprietaire> getListPro(string nom, int opt)
        public IQueryable<tbl_Proprio> getListPro(string nom, int opt)
        {
            switch (opt)
            {
                case 1:

                    break;
                case 2:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Titre.Contains(nom)
                        select prop;
                    break;
                case 3:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Prenom.Contains(nom)
                        select prop;
                    break;
                case 4:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Nom_Pro.Contains(nom)
                        select prop;
                    break;
                case 5:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Nom_p2.Contains(nom)
                        select prop;
                    break;
                case 6:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.NumRuePro.Contains(nom)
                        select prop;
                    break;
                case 7:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.TypeRuePro.Contains(nom)
                        select prop;
                    break;
                case 8:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.RueProp.Contains(nom)
                        select prop;
                    break;
                case 9:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.CodePostalPro.Contains(nom)
                        select prop;
                    break;
                case 10:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.VillePro.Contains(nom)
                        select prop;
                    break;
                case 11:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Tel.Contains(nom)
                        select prop;
                    break;
                case 12:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.TaxeFonc.Contains(nom)
                        select prop;
                    break;
                default:
                    CustQuery =
                        from prop in dat.tbl_Proprio
                        where prop.Nom_Pro.Contains(nom)
                        select prop;
                    break;
            }
            return CustQuery;
        }



        public void modifBD(tbl_Proprio row, int opt)
        {
            tbl_Proprio tt = dat.tbl_Proprio.Single(p => p.ID_Pro == row.ID_Pro);
            tt.Nom_Pro = "ABBAA";
            dat.SubmitChanges();
        }

        public void modifProprioBD(tbl_Proprio row)
        {
            tbl_Proprio tt = dat.tbl_Proprio.Single(p => p.ID_Pro == row.ID_Pro);
            modifProprio(tt, row);
            dat.SubmitChanges();
        }


        public void modifProprio(tbl_Proprio newp,tbl_Proprio oldp)
        {
            //newp.ID_Pro = oldp.ID_Pro;
            newp.Titre = oldp.Titre;
            newp.Prenom = oldp.Prenom;
            newp.Nom_Pro = oldp.Nom_Pro;
            newp.Nom_p2 = oldp.Nom_p2;
            newp.NumRuePro = oldp.NumRuePro;
            newp.TypeRuePro = oldp.TypeRuePro;
            newp.RueProp = oldp.RueProp;
            newp.CodePostalPro = oldp.CodePostalPro;
            newp.VillePro = oldp.VillePro;
            newp.Tel = oldp.Tel;
            newp.TaxeFonc = oldp.TaxeFonc;
        }



        public ObservableCollection<Immeuble> getListImm(string nom, int opt)
        {
            DataClasses1DataContext dat = new DataClasses1DataContext();
            string req = "SELECT ID_Imm, TypeRueImm, RueImm, VilleImm,CodePostaleImm, NumImm, Reponse,ModifierPar FROM dbo.tbl_Immeuble WHERE ";
            switch (opt)
            {
                case 1:
                    req = req + "ID_Imm";
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    req = req + "TypeRueImm";
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    req = req + "RueImm";
                    Console.WriteLine("Case 1");
                    break;
                case 4:
                    req = req + "VilleImm";
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    req = req + "CodePostaleImm";
                    Console.WriteLine("Case 1");
                    break;
                case 6:
                    req = req + "NumImm";
                    Console.WriteLine("Case 2");
                    break;
                case 7:
                    req = req + "Reponse";
                    Console.WriteLine("Case 1");
                    break;
                case 8:
                    req = req + "ModifierPar";
                    Console.WriteLine("Case 2");
                    break;
                default:
                    req = req + "ID_Imm";
                    Console.WriteLine("Default case");
                    break;
            }
            req = req + " LIKE {0}";
            var proplist = new ObservableCollection<Immeuble>();
            proplist = Convert<Immeuble>(dat.ExecuteQuery<Immeuble>(@req, "%" + nom + "%"));
            return proplist;


        }

        public ObservableCollection<T> Convert<T>(IEnumerable<T> original)
        {
            return new ObservableCollection<T>(original);
        }

        public List<BaseTMT> getListImmTitre(string titre)
        {
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var g = from a in dat.BaseTMT where a.Titre.Contains(titre) select a;
            return g.ToList();
        }

        public IEnumerable<Proprietaire> getListProNom(string nom)
        {
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var proplist = dat.ExecuteQuery<Proprietaire>(@"SELECT ID_Pro, Titre, Prenom, Nom_Pro, 
            Nom_p2, NumRuePro, TypeRuePro, RueProp, CodePostalPro, VillePro, Tel,TaxeFonc
            FROM   dbo.tbl_Proprio
            WHERE  Nom_Pro LIKE {0}", "%"+nom+"%");
            return proplist;
        }


        public IEnumerable<Proprietaire> getListFicheNom(string nom)
        {
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var proplist = dat.ExecuteQuery<Proprietaire>(@"SELECT ID_Fiche, ID_Pro, ID_Imm, Asterix, 
            Commentaire1, Commentaire2, EnvoiCourrier, CD_Fiche, DM_Fiche, Reponse, ModifierPar,SSMA_TimeStamp
            FROM   dbo.tbl_Fiches
            WHERE  DM_Fiche = {0}", "16/08/2000");
            return proplist;
        }

        public List<BaseTMT> getListImmNom(string nom)
        {
            DataClasses1DataContext dat = new DataClasses1DataContext();
            /*var customers = dat.ExecuteQuery<tmt>(@"SELECT Numero, Titre, Prénom, Nom Propriétaire, 
            Numéro rue Propriétaire, TypeRuePropriétaire, Rue Propriétaire, Code Postal Propriétaire, Ville Propriétaire, TypeRueImmeuble, Commentaire 2,Rue Immeuble,
            Ville Immeuble,Asterix,Commentaire 1,Téléphone,Taxe fonc,Envoi Courrier,CD_Fiche,DM_Fiche,Code postale Immeuble,Numéro Immeuble,Nom p2,Reponse,Modifier par
            FROM   TestDB.dbo.BaseTMT
            WHERE  Nom Propriétaire = {0}", "ABBOU");*/

            var ficheslist = dat.ExecuteQuery<Fiches>(@"SELECT ID_Fiche, ID_Pro, ID_Imm, Asterix, 
            Commentaire1, Commentaire2, EnvoiCourrier, CD_Fiche, DM_Fiche, Reponse, ModifierPar,SSMA_TimeStamp
            FROM   dbo.tbl_Fiches
            WHERE  DM_Fiche = {0}", "16/08/2000");
            //Console.WriteLine("TEST " );
            //foreach (Fiches c in ficheslist)
            //    Console.WriteLine("DM_FICHE = " + c.DM_Fiche);
            var g = from a in dat.BaseTMT where a.Nom_Propriétaire.Contains(nom) select a;
            return g.ToList();
        }

        public List<BaseTMT> getListFiches(string nom)
        {
            List<Fiches> f = new List<Fiches>();
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var g = from a in dat.BaseTMT where a.Nom_Propriétaire.Contains(nom) select a;
            /*foreach (BaseTMT element in g.ToList())
            {

                f.Add;
            }*/
            return g.ToList();
        }


        public List<tbl_Fiches> getListFiches(int id)
        {
            List<tbl_Fiches> f = new List<tbl_Fiches>();
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var g = from a in dat.tbl_Fiches where a.ID_Pro.Equals(id) select a;
            /*foreach (BaseTMT element in g.ToList())
            {

                f.Add;
            }*/
            return g.ToList();
        }

        public tbl_Immeuble getImmeubles(int id)
        {
            List<tbl_Immeuble> f = new List<tbl_Immeuble>();
            DataClasses1DataContext dat = new DataClasses1DataContext();
            var g = from a in dat.tbl_Immeuble where a.ID_Imm.Equals(id) select a;
            /*foreach (BaseTMT element in g.ToList())
            {

                f.Add;
            }*/
            return (tbl_Immeuble)g.ToList()[0];
        }


    }
}
