using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Gbook.Model;
using Gbook.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Gbook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
            BibliotekaModel.NapuniInfo();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ime = textBoxIme.Text;
            string sifra = passwordBoxSifra.Password;

            //ako je admin
            foreach(ZaposlenikModel i in BibliotekaModel.Zaposlenici)
            if (i.info.Ime == ime &&  i.info.Sifra==sifra && i.Tip_radnika=="admin")
                Frame.Navigate(typeof(AdminView));

            //ako je bibliotekar
            foreach (ZaposlenikModel i in BibliotekaModel.Zaposlenici)
                if (i.info.Ime == ime && i.info.Sifra == sifra && i.Tip_radnika == "bibliotekar")
                    Frame.Navigate(typeof(Bibliotekar));

            //ako je portir
            foreach (ZaposlenikModel i in BibliotekaModel.Zaposlenici)
                if (i.info.Ime == ime && i.info.Sifra == sifra && i.Tip_radnika == "portir")
                    Frame.Navigate(typeof(Portir));

            //ako je clan
            foreach (ClanModel i in BibliotekaModel.Clanovi)
                if (i.info.Ime == ime && i.info.Sifra == sifra )
                    Frame.Navigate(typeof(Clan));

           



        }
    }
}
