using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Fenetre;

namespace TestApp.Function
{
    class PropFonctions
    {
        public static void AfficheGoogleSearch(string adress){
            Streetview view = new Streetview();
            view.Show();
            Uri uri = new Uri(@adress);
            view.Browser.Navigate(uri);
           }
    }
}
