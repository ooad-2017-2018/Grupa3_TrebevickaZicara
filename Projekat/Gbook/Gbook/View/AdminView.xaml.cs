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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Gbook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminView : Page
    {
        public AdminView()
        {
            this.InitializeComponent();
        }


        

        private void Odjava_Click(object sender, RoutedEventArgs e)
        {

            Frame.Navigate(typeof(Login));


        }

        private async void DodajSlikuButton_Click(object sender, RoutedEventArgs e)
        {
           

                FileOpenPicker izbornikFajlaSlike = new FileOpenPicker();
            izbornikFajlaSlike.SuggestedStartLocation =

                PickerLocationId.PicturesLibrary;
            izbornikFajlaSlike.FileTypeFilter.Add(".bmp");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpeg");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpg");
            izbornikFajlaSlike.FileTypeFilter.Add(".png");

                StorageFile fajlSlike = await izbornikFajlaSlike.PickSingleFileAsync();
            if (fajlSlike != null)

                {

                    using (IRandomAccessStream tokFajla = await fajlSlike.OpenAsync(FileAccessMode.Read))

                    {

                    BitmapImage slika = new BitmapImage();
                    slika.SetSource(tokFajla);
                    polje_za_sliku.Source = slika;

                    }
                }

            

        }

        public void AnulirajStanje()
        {
            Ime.Text = "";
            Prezime.Text = Adresa.Text =Grad.Text= Email.Text = brojLicneKarte.Text =BrojTelefona.Text=jmbgZaposlenika.Text= "";
            DatumRodjenja.Date = DatumZaposlenja.Date= DateTime.Now;
            rb_admin.IsChecked = rb_bibliotekar.IsChecked = rb_portir.IsChecked = false;
        }

        private async void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (Ime.Text == "" || Prezime.Text == "" || BrojTelefona.Text == "" || jmbgZaposlenika.Text == "")
            {
                var messageDialog = new MessageDialog("Neispravni podaci!");
                await messageDialog.ShowAsync();
            }
            else if (rb_bibliotekar.IsChecked == false && false== rb_portir.IsChecked && false== rb_admin.IsChecked)
            {
                var messageDialog = new MessageDialog("Odaberite tip zaposlenika!");
                await messageDialog.ShowAsync();
            }
            else
            {
                string tip = "";
                if (rb_admin.IsChecked == true) tip = "admin";
                else if (rb_bibliotekar.IsChecked==true) tip = "bibliotekar";
                else if (rb_portir.IsChecked==true) tip = "portir";
                try
                {
                    ZaposlenikModel z;
                    BibliotekaModel.Zaposlenici.Add(z=new ZaposlenikModel(Ime.Text, Prezime.Text, Convert.ToInt64(jmbgZaposlenika.Text), new DateTime(DatumRodjenja.Date.Year, DatumRodjenja.Date.Month, DatumRodjenja.Date.Day, 11, 11, 11), Grad.Text, Adresa.Text, Convert.ToInt64(BrojTelefona.Text), Email.Text, "sifra", new DateTime(DatumZaposlenja.Date.Year, DatumZaposlenja.Date.Month, DatumZaposlenja.Date.Day, 11,11,11), 1000, tip));
                    BibliotekaModel.Iskaznice.Add(new IskaznicaModel(z));
                    var messageDialog = new MessageDialog("Uspješno unesen zaposlenik!");
                    await messageDialog.ShowAsync();

                    AnulirajStanje();
                }
                catch(Exception ex)
                {
                    var messageDialog1 = new MessageDialog(ex.Message);
                    await messageDialog1.ShowAsync();
                   
                }

                

            }

          
        }

        /*
         Nema potrebe nikako za onim tabom kartica, napravit ćemo da se automatski kreiraju kartice
         kad se unese zaposlenik, a ne onako dupli unos, nema smisla

        public void AnulirajBrisanjeTab()
        {
            ImeObrisanog.Text = PrezimeObrisanog.Text = JMBGObrisanog.Text = "";
        }

        private async void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            bool testna = false;

            foreach (ZaposlenikModel i in BibliotekaModel.Zaposlenici)
            {
                if(i.info.Ime==ImeObrisanog.Text && i.info.Prezime==PrezimeObrisanog.Text && i.info.Jmbg==Convert.ToInt64(JMBGObrisanog.Text))
                {
                    BibliotekaModel.Zaposlenici.Remove(i);
                    var messageDialog1 = new MessageDialog("Uspješno ste obrisali zaposlenika!");
                    await messageDialog1.ShowAsync();
                    testna = true;
                    AnulirajBrisanjeTab();
                }

            }
            if (testna == false)
            {
                var messageDialog1 = new MessageDialog("Unijeli ste neispravne podatke!");
                await messageDialog1.ShowAsync();
            }
        }

        private void PonistiObrisanoButton_Click(object sender, RoutedEventArgs e)
        {
            AnulirajBrisanjeTab();
        }

        private void Ponisti_Click(object sender, RoutedEventArgs e)
        {
            AnulirajStanje();
        }

        private async void ucitajSliku_Click(object sender, RoutedEventArgs e)
        {

            FileOpenPicker izbornikFajlaSlike = new FileOpenPicker();
            izbornikFajlaSlike.SuggestedStartLocation =

                PickerLocationId.PicturesLibrary;
            izbornikFajlaSlike.FileTypeFilter.Add(".bmp");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpeg");
            izbornikFajlaSlike.FileTypeFilter.Add(".jpg");
            izbornikFajlaSlike.FileTypeFilter.Add(".png");

            StorageFile fajlSlike = await izbornikFajlaSlike.PickSingleFileAsync();
            if (fajlSlike != null)

            {

                using (IRandomAccessStream tokFajla = await fajlSlike.OpenAsync(FileAccessMode.Read))

                {

                    BitmapImage slika = new BitmapImage();
                    slika.SetSource(tokFajla);
                    slikaIskaznica.Source = slika;

                }
            }

        }

       
        private void iskaznicaDodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              ///  BibliotekaModel.Kartice.Add(new KarticaModel(DateTime.Now,1, ))


            }
            catch 
            {

            }
        }
        */
    }
}
