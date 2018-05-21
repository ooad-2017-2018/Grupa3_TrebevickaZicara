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
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.Storage.Streams;
using Gbook.Model;
using Microsoft.WindowsAzure.MobileServices;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Gbook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Clan : Page
    {
        public Clan()
        {
            this.InitializeComponent();
            lista.Text += "Derviš i smrt                Meša Selimović                  Rok vraćanja: 27.05.18.\n";
            lista.Text += "Ruža I                          Nura Bazdulj Hubijar          Rok vraćanja: 05.06.18.\n";
            lista.Text += "Ana Karenjina              Lav Nikolajevič Tolstoj        Rok vraćanja: 06.06.18\n";

        }

        /*
        public List<KnjigaModel> napuni_listu_iznajmljenih_knjiga()
        {


            return new List<KnjigaModel>();
        }
        */

        private void Odjava_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(Login));


        }

        private async void pretraga_za_clana_Click(object sender, RoutedEventArgs e)
        {
            string trazimo = pretraga_txtbox.Text;
         

            if (pretraga_txtbox.Text == "")
            {
                var messageDialog1 = new MessageDialog("Polje za pretragu ne smije biti prazno!");
                await messageDialog1.ShowAsync();
            }
            else if (pretraga_txtbox.Text == "ćao")
            {
                var messageDialog1 = new MessageDialog("Nema rezultata za pretragu!");
                await messageDialog1.ShowAsync();
            }
            else ispis_pretrage.Text = "Tvrđava    Meša Selimović      Na raspolaganju: DA";

            /*
             nemam sad vakta uglavnom pretrazi iz biblioteke
             * */

        }
    }
}
