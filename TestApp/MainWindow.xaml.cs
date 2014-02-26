using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestApp.DB;
using TestApp.Fenetre;
using TestApp.Function;
using TestApp.Objects;

namespace TestApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<tbl_Proprio> fiche = new ObservableCollection<tbl_Proprio>();
        public ObservableCollection<tbl_Immeuble> immeubles = new ObservableCollection<tbl_Immeuble>();
        public propList fiche = new propList();
        /*private ObservableCollection<tbl_Proprio> fiche;
        public ObservableCollection<tbl_Proprio> Fiche
        {
            get { return fiche; }
            set { NotifyPropertyChanged(ref fiche, value); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string nomPropriete)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nomPropriete));
        }
        private bool NotifyPropertyChanged<T>(ref T variable, T valeur, [CallerMemberName] string nomPropriete = null)
        {
            if (object.Equals(variable, valeur)) return false;
            variable = valeur;
            NotifyPropertyChanged(nomPropriete);
            return true;
        }*/


        DBMethods met;

        public MainWindow()
        {
            InitializeComponent();
             met = new DBMethods();
             dataGridProprietaire.ItemsSource = fiche;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }


        private void FieldP_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                case "FieldPTitre":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPTitre.Text, 2);
                    break;
                case "FieldPNom":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPNom.Text, 4);
                    break;
                case "FieldPPrenom":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPPrenom.Text, 3);
                    break;
                case "FieldPNomP2":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPNomP2.Text, 5);
                    break;
                case "FieldPNumero":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPNumero.Text, 6);
                    break;
                case "FieldPVoix":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPVoix.Text, 7);
                    break;
                case "FieldPAdresse":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPAdresse.Text, 8);
                    break;
                case "FieldPCodepostal":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPCodepostal.Text, 9);
                    break;
                case "FieldPVille":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPVille.Text, 10);
                    break;
                case "FieldPTelephone":
                    dataGridProprietaire.ItemsSource = met.getListPro(FieldPTelephone.Text, 11);
                break;
                default:
                break;
            }
           
        }



        private void MenuConfig_Click(object sender, RoutedEventArgs e)
        {
            Configuration windows = new Configuration();
            windows.Show();
        }

        public void UpdateProprietaire(string field, string text)
        {
            dataGridProprietaire.ItemsSource = null;
            switch (field)
            {
                case "FieldPTitre":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 2);
                    break;
                case "FieldPNom":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 4);
                    break;
                case "FieldPPrenom":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 3);
                    break;
                case "FieldPNomP2":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 5);
                    break;
                case "FieldPNumero":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 6);
                    break;
                case "FieldPVoix":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 7);
                    break;
                case "FieldPAdresse":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 8);
                    break;
                case "FieldPCodepostal":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 9);
                    break;
                case "FieldPVille":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 10);
                    break;
                case "FieldPTelephone":
                    dataGridProprietaire.ItemsSource = met.getListPro(text, 11);
                    break;
                default:
                    break;
            }
        }

        public void checkSearchField()
        {
            if (FieldPTitre.Text.Length != 0)
            {
                UpdateProprietaire("FieldPTitre", FieldPTitre.Text);
            }else if(FieldPNom.Text.Length != 0){
                UpdateProprietaire("FieldPNom", FieldPNom.Text);
            }else if(FieldPPrenom.Text.Length != 0){
                UpdateProprietaire("FieldPPrenom", FieldPPrenom.Text);
            }else if(FieldPNomP2.Text.Length != 0){
                UpdateProprietaire("FieldPNomP2", FieldPNomP2.Text);
            }else if(FieldPNumero.Text.Length != 0){
                UpdateProprietaire("FieldPNumero", FieldPNumero.Text);
            }else if(FieldPVoix.Text.Length != 0){
                UpdateProprietaire("FieldPVoix", FieldPVoix.Text);
            }else if(FieldPAdresse.Text.Length != 0){
                UpdateProprietaire("FieldPAdresse", FieldPAdresse.Text);
            }else if(FieldPCodepostal.Text.Length != 0){
                UpdateProprietaire("FieldPCodepostal", FieldPCodepostal.Text);
            }else if(FieldPVille.Text.Length != 0){
                UpdateProprietaire("FieldPVille", FieldPVille.Text);
            }else if(FieldPTelephone.Text.Length != 0){
                UpdateProprietaire("FieldPTelephone", FieldPTelephone.Text);
            }else if (FieldPTelephone.Text.Length != 0){
                UpdateProprietaire("FieldPTelephone", FieldPTelephone.Text);
            }
            


        }

        private void FieldI_TextChanged(object sender, TextChangedEventArgs e)
        {
            DBMethods met = new DBMethods();
            dataGridImmeuble.ItemsSource = null;
            switch (((TextBox)sender).Name)
            {
                case "FieldINumero":
                    dataGridImmeuble.ItemsSource = met.getListImm(FieldINumero.Text, 2);
                    break;
                case "FieldIVoix":
                    dataGridImmeuble.ItemsSource = met.getListImm(FieldIVoix.Text, 4);
                    break;
                case "FieldIAdresse":
                    dataGridImmeuble.ItemsSource = met.getListImm(FieldIAdresse.Text, 3);
                    break;
                case "FieldICodePostal":
                    dataGridImmeuble.ItemsSource = met.getListImm(FieldICodePostal.Text, 5);
                    break;
                case "FieldIVille":
                    dataGridImmeuble.ItemsSource = met.getListImm(FieldIVille.Text, 6);
                    break;
                default:
                    break;
            }
        }

        private void dataGridProprietaire_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                if (dataGridProprietaire.SelectedItem != null)
                {
                    if (dataGridProprietaire.SelectedItem is tbl_Proprio)
                    {
                        tbl_Proprio proprio = (tbl_Proprio)dataGridProprietaire.SelectedItem;
                        List<tbl_Fiches> ff = met.getListFiches(proprio.ID_Pro);
                        List<tbl_Immeuble> imms = new List<tbl_Immeuble>();
                        for (int i = 0; i < ff.Count; i++) // Loop through List with for
	                    {
                            imms.Add(met.getImmeubles(ff[i].ID_Imm.Value));
                            
                            //MessageBox.Show(ff[i].EnvoiCourrier);
	                    }
                        dataGridImmeuble.ItemsSource = imms;
                        Console.WriteLine("test");
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void dataGridProprietaire_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void RechGoogle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGridProprietaire.SelectedItem != null)
                {
                    if (dataGridProprietaire.SelectedItem is tbl_Proprio)
                    {
                        var row = (tbl_Proprio)dataGridProprietaire.SelectedItem;

                        if (row != null)
                        {
                            string adress = "http://www.google.fr/search?q=" + row.NumRuePro + "+" + row.TypeRuePro + "+" + row.RueProp + "+" + row.VillePro;
                            PropFonctions.AfficheGoogleSearch(adress);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void ModifierProp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataGridProprietaire.SelectedItem != null)
                {
                    if (dataGridProprietaire.SelectedItem is tbl_Proprio)
                    {
                        var row = (tbl_Proprio)dataGridProprietaire.SelectedItem;

                        if (row != null)
                        {
                            // Do something...
                            //row.Nom_Pro = "ABBAA";
                            //DBMethods met = new DBMethods();
                            //met.modifBD(row, 1);

                            AffProprietaire prop = new AffProprietaire();
                            prop.Prop = row;
                            /*prop.AddedUser += (sender, e) => 
                                {
                                    // Add the info to your ObservableCollection.
                                    this.fiche.Add(e.AddInfo);
                                }
                            */
                            var okk = prop.ShowDialog();
                            if (okk == true)
                            {
                                checkSearchField();
                            }
                            //prop.Show();
                            

                            //string adress = "http://www.google.fr/search?q=" + row.NumRuePro + "+" + row.TypeRuePro + "+" + row.RueProp + "+" + row.VillePro;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void SupprimerProp_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nouveau_Click(object sender, RoutedEventArgs e)
        {
            DBMethods met = new DBMethods();
            dataGridProprietaire.ItemsSource = met.testACCESS();
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            //checkSearchField();
            Console.Write("test");
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            Console.Write("test");
        }


    }
}
