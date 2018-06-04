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
    public sealed partial class Bibliotekar : Page
    {
        public Bibliotekar()
        {
            this.InitializeComponent();
           /* dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;*/
        }

        private void Odjava_Click(object sender, RoutedEventArgs e)
        {
         
                    Frame.Navigate(typeof(Login));

           
        }

        private async void Ucitavanje_slike(object sender, RoutedEventArgs e, Image o)
        {
            FileOpenPicker izbornikFajlaSlike = new FileOpenPicker(); izbornikFajlaSlike.SuggestedStartLocation =

               PickerLocationId.PicturesLibrary; izbornikFajlaSlike.FileTypeFilter.Add(".bmp"); izbornikFajlaSlike.FileTypeFilter.Add(".jpeg"); izbornikFajlaSlike.FileTypeFilter.Add(".jpg"); izbornikFajlaSlike.FileTypeFilter.Add(".png");

            StorageFile fajlSlike = await izbornikFajlaSlike.PickSingleFileAsync(); if (fajlSlike != null)

            {

                using (IRandomAccessStream tokFajla = await fajlSlike.OpenAsync(FileAccessMode.Read))

                {

                    BitmapImage slika = new BitmapImage();
                    slika.SetSource(tokFajla);
                    o.Source = slika;
                   

                }
            }
        }

       
            private void DodajSlikuButton_Click(object sender, RoutedEventArgs e)
            {

                Ucitavanje_slike(sender, e, polje_za_sliku);
               
                }



            
        

        private async void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (Ime.Text == "" || Prezime.Text == "" || BrojTelefona.Text == "" || jmbgClana.Text == "")
            {
                var messageDialog = new MessageDialog("Neispravni podaci!");
                await messageDialog.ShowAsync();
            }
            
            else
            {
               
                try
                {

                    ClanModel z;
                    BibliotekaModel.Clanovi.Add(z=new ClanModel(new OsobaINFOModel(Ime.Text, Prezime.Text, Convert.ToInt64(jmbgClana.Text), new DateTime(DatumRodjenja.Date.Year, DatumRodjenja.Date.Month, DatumRodjenja.Date.Day, 11, 11, 11), Adresa.Text, Convert.ToInt64(BrojTelefona.Text), "sifra"), DateTime.Now));
                    BibliotekaModel.Kartice.Add(new KarticaModel(DateTime.Now, z));
                  
                    var messageDialog = new MessageDialog("Uspješno unesen član!");
                    await messageDialog.ShowAsync();

                    AnulirajStanje();
                }
                catch (Exception ex)
                {
                    var messageDialog1 = new MessageDialog(ex.Message);
                    await messageDialog1.ShowAsync();

                }



            }
        }


        public void AnulirajStanje()
        {
            Ime.Text = "";
            Prezime.Text = Adresa.Text  = BrojTelefona.Text = jmbgClana.Text = "";
            DatumRodjenja.Date = DateTime.Now;
           // polje_za_sliku.Source = null; 
            polje_za_sliku.Source = new BitmapImage(new Uri(polje_za_sliku.BaseUri, "Assets/StoreLogo.png"));

            //ne radi, ali ni ne baca izuzetak haha
          
        }

        public void AnulirajBrisanjeTab()
        {
            ImeObrisanog.Text = PrezimeObrisanog.Text = jmbgObrisanog.Text = "";
        }

        private async void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            string ime = ImeObrisanog.Text;
            string prezime = PrezimeObrisanog.Text;
            string jmbg = jmbgObrisanog.Text;

            bool testna = false;

            foreach (ClanModel i in BibliotekaModel.Clanovi)
            {
                if (i.info.Ime == ImeObrisanog.Text && i.info.Prezime == PrezimeObrisanog.Text && i.info.Jmbg == Convert.ToInt64(jmbgObrisanog.Text))
                {
                    BibliotekaModel.Clanovi.Remove(i);
                    var messageDialog1 = new MessageDialog("Uspješno ste obrisali člana!");
                    await messageDialog1.ShowAsync();
                    testna = true;
                    AnulirajBrisanjeTab();
                    break;
                }

            }
            if (testna == false)
            {
                var messageDialog1 = new MessageDialog("Unijeli ste neispravne podatke!");
                await messageDialog1.ShowAsync();
                AnulirajBrisanjeTab();
            }
        }

        private void PonistiObrisanoButton_Click(object sender, RoutedEventArgs e)
        {
            AnulirajBrisanjeTab();
        }

        private void Pretrazi_Click(object sender, RoutedEventArgs e)
        {
            if (rb_zaposlenici.IsChecked == true)
            {
                tekst.Text = "Zaposlenici sa najvećim platama:\n1. Meho Mehić\n2. Fata Fatić\n3. Habiba Habi";
            }
            else if (rb_knjige.IsChecked == true)
            {
                tekst.Text = "Najčitanije knjige mjeseca maja:\n1. Tvrđava - Meša Selimović\n2. Ježeva kućica\n3. Čekajući Godoa";
            }
            else if (rb_clanovi.IsChecked == true)
            {
                tekst.Text = "Najaktivniji članovi:\n1. Damir Damirovic\n2. Selma Selmic\n3. Emir Emirovic";
            }
            else tekst.Text = "";

        }



        private async void Spasi_knjigu_Click(object sender, RoutedEventArgs e)
        {
            //moram vrijeme ovo napraviti normala
            
            try
            {
                BibliotekaModel.Knjige.Add(new KnjigaModel(Naziv.Text, Autor.Text, Convert.ToInt64(isbn.Text), new DateTime(dateTimePicker1.Date.Year), Convert.ToInt32(Broj_kopija.Text)));
                var messageDialog1 = new MessageDialog("Uspješno ste unijeli knjigu!");
                await messageDialog1.ShowAsync();
                Naziv.Text = Autor.Text = isbn.Text = Broj_kopija.Text = "";
                // dateTimePicker1.Date.Year = DateTime.Now.Year;
                slika_knjiga.Source = null;
            }
            catch
            {

            }
        }

        private  void DodajSlikuk_Click(object sender, RoutedEventArgs e)
        {
            Ucitavanje_slike(sender, e, slika_knjiga);


        }

        private async void Obrisik_Click(object sender, RoutedEventArgs e)
        {
            //doraditi ovo fino
            var messageDialog1 = new MessageDialog("Uspješno ste obrisali knjigu!");
            await messageDialog1.ShowAsync();
            Naslov_k.Text = isbn_b.Text = "";
        
    }
    }
}
