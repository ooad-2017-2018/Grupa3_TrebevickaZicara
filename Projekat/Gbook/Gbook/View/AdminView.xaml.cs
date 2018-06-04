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
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

using Gbook.View;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Gbook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminView : Page
    {
        static int id_brojac = 1;

        public AdminView()
        {
            this.InitializeComponent();
         
        }

        public void fja_za_bazu(string tip) {
            IMobileServiceTable<GbookAdmin> userTableObj = App.MobileService.GetTable<GbookAdmin>();
           
          
                try

                {

                GbookAdmin obj = new GbookAdmin();
                obj.id = Convert.ToString(id_brojac);
                obj.ime = Ime.Text;
                obj.prezime = Prezime.Text;
                obj.jmbg = jmbgZaposlenika.Text;
                obj.adresa = Adresa.Text;
                obj.email=Email.Text;


                  userTableObj.InsertAsync(obj);
                id_brojac++;
                  //  MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");
                    //msgDialog.ShowAsync();

                }

                catch (Exception ex)
                {

                    MessageDialog msgDialogError = new MessageDialog("Error sa bazom : " + ex.ToString());

                    msgDialogError.ShowAsync();
                }

            

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
                 

            /*
             * zaštoooo nećeee image, zašto nmg uključiti System.Drawings
             * 
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku";
                dlg.Filter = "jpg files (*.jpg)|*.jpg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    polje_za_sliku.Image = new Bitmap(dlg.FileName);
                }
            }


            */

        }

        public void AnulirajStanje()
        {
            Ime.Text = "";
            Prezime.Text = Adresa.Text =Grad.Text= Email.Text = brojLicneKarte.Text =BrojTelefona.Text=jmbgZaposlenika.Text= "";
            DatumRodjenja.Date = DatumZaposlenja.Date= DateTime.Now;
            rb_admin.IsChecked = rb_bibliotekar.IsChecked = rb_portir.IsChecked = false;
           // polje_za_sliku.Source =null;  
            //ne kontam kako da mu opet stavim kao source onu početnu sliku
           // polje_za_sliku.Source = "ms-appx:///Assets/Wide310x150Logo.png";
           // BitmapImage image = new BitmapImage(new Uri("ms-appx:///Assets/Wide310x150Logo.png", UriKind.Relative));
            //BitmapImage image1 = new BitmapImage(new Uri("ms - appx:///Assets/Wide310x150Logo.png", UriKind.Absolute));
          //BitmapImage image2 = new BitmapImage(new Uri("ms - appx:/Assets/Wide310x150Logo.png", UriKind.Relative));
          //  polje_za_sliku.Source = new BitmapImage(new Uri(this.BaseUri, "Assets / Wide310x150Logo.png"));
            polje_za_sliku.Source = new BitmapImage(new Uri(polje_za_sliku.BaseUri, "Assets/StoreLogo.png"));

            //ne radi, ali ni ne baca izuzetak haha
            // / MyProject; component / Images / down.png"
            // polje_za_sliku.Source = image2;
        }

      //  "/Images/800x600/BackgroundTile.bmp"
       // ms-appx:/Images/800x600/BackgroundTile.bmp



        private async void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            tekst_pretrage.Text = ""; //ovo za pretrage, ...dok skontam nesta
            tekst.Text = "";
            trazilica.Text = "";
            rb_zaposlenici.IsChecked = rb_knjige.IsChecked = rb_clanovi.IsChecked = false;




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
                    fja_za_bazu(tip);
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

        private void btn_Pretrazi_Click(object sender, RoutedEventArgs e)
        {

            tekst_pretrage.Text = "";
            tekst.Text = "";
            trazilica.Text = "";

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

        /*
         Nema potrebe nikako za onim tabom kartica, napravit ćemo da se automatski kreiraju kartice
         kad se unese zaposlenik, a ne onako dupli unos, nema smisla
         */
        public void AnulirajBrisanjeTab()
        {
            ImeObrisanog.Text = PrezimeObrisanog.Text = JMBGObrisanog.Text = "";
        }

        private async void ObrisiButton_Click(object sender, RoutedEventArgs e)
        {
            tekst_pretrage.Text = "";
            trazilica.Text = "";
            tekst.Text = "";
            rb_zaposlenici.IsChecked = rb_knjige.IsChecked = rb_clanovi.IsChecked = false;


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

        
        private void Ponisti_Click(object sender, RoutedEventArgs e)
        {
            AnulirajStanje();
        }

        private void Trazi_Click(object sender, RoutedEventArgs e)
        {
            tekst_pretrage.Text = "";
            tekst.Text = "";
            rb_zaposlenici.IsChecked = rb_knjige.IsChecked = rb_clanovi.IsChecked = false;


            string trazimo = trazilica.Text;
            foreach(ZaposlenikModel i in BibliotekaModel.Zaposlenici)
            {
                if (i.info.Ime == trazimo || i.info.Prezime == trazimo)
                {
                    tekst_pretrage.Text += i.info.to_String();
                    tekst_pretrage.Text += "\n";
                }
            }
            AnulirajBrisanjeTab();
            AnulirajStanje();
        }

        private async void PonistiSlikuButton_Click(object sender, RoutedEventArgs e)
        {

            /*
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo == null)
            {
                // User cancelled photo capture
                return;
            }


            StorageFolder destinationFolder =
   await ApplicationData.Current.LocalFolder.CreateFolderAsync("ProfilePhotoFolder",
        CreationCollisionOption.OpenIfExists);
        
        

            await photo.CopyAsync(destinationFolder, "ProfilePhoto.jpg", NameCollisionOption.ReplaceExisting);
            await photo.DeleteAsync();

            //polje_za_sliku.Source =;
            */

            var UslikajUI = new CameraCaptureUI();
            UslikajUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
            UslikajUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);
            StorageFile slika = await UslikajUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            IRandomAccessStream stream = await slika.OpenAsync(FileAccessMode.Read);
            BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
            SoftwareBitmap softwareBitmap = await decoder.GetSoftwareBitmapAsync();

            SoftwareBitmap softwareBitmapBGR8 = SoftwareBitmap.Convert(softwareBitmap,
            BitmapPixelFormat.Bgra8,
            BitmapAlphaMode.Premultiplied);

            SoftwareBitmapSource bitmapSource = new SoftwareBitmapSource();
            await bitmapSource.SetBitmapAsync(softwareBitmapBGR8);

            polje_za_sliku.Source = bitmapSource;


        }
        /*
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
