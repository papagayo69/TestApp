using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestApp.DB;

namespace TestApp.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour AffProprietaire.xaml
    /// </summary>
    public partial class AffProprietaire : Window
    {
        private tbl_Proprio prop;

        public tbl_Proprio Prop
        {
            get { return prop; }
            set { 
                prop = value;
                textBoxTitre.Text = prop.Titre;
                textBoxPrenom.Text = prop.Prenom;
                textBoxNomProp.Text = prop.Nom_Pro;
                textBoxNomp2.Text = prop.Nom_p2;
                textBoxNumRuePro.Text = prop.NumRuePro;
                textBoxTypeRuePro.Text = prop.TypeRuePro;
                textBoxRueProp.Text = prop.RueProp;
                textBoxCodePostalPro.Text = prop.CodePostalPro;
                textBoxVillePro.Text = prop.VillePro;
                textBoxTel.Text = prop.Tel;
                textBoxTaxeFonc.Text = prop.TaxeFonc;
            }
        }
        public AffProprietaire()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            Prop.ID_Pro = Prop.ID_Pro;
            Prop.Titre = textBoxTitre.Text;
            Prop.Prenom = textBoxPrenom.Text;
            Prop.Nom_Pro = textBoxNomProp.Text;
            Prop.Nom_p2 = textBoxNomp2.Text;
            Prop.NumRuePro = textBoxNumRuePro.Text;
            Prop.TypeRuePro = textBoxTypeRuePro.Text;
            Prop.RueProp = textBoxRueProp.Text;
            Prop.CodePostalPro = textBoxCodePostalPro.Text;
            Prop.VillePro = textBoxVillePro.Text;
            Prop.Tel = textBoxTel.Text;
            Prop.TaxeFonc = textBoxTaxeFonc.Text;
            DBMethods met = new DBMethods();
            met.modifProprioBD(Prop);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
