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

        private async void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            if (Ime.Text == "" || Prezime.Text == "" || BrojTelefona.Text == "" || jmbgZaposlenika.Text == "")
            {
                var messageDialog = new MessageDialog("Neispravni podaci!");
                await messageDialog.ShowAsync();
            }
            else
            {

              //  BibliotekaModel.Zaposlenici.Add(new ZaposlenikModel(Ime.Text, Prezime.Text, Convert.ToInt64(jmbgZaposlenika.Text), DatumRodjenja, 


                var messageDialog = new MessageDialog("Uspješno unesen zaposlenik!");
                await messageDialog.ShowAsync();

            }

          
        }

        
    }
}
