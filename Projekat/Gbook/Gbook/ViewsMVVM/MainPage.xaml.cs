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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Gbook.View;
using Gbook.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Gbook
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        private async void btnlogIn_ClickAsync(object sender, RoutedEventArgs e)
        {
            //..validacija za korisnike(clanove) sistema
            if (Username.Text.Length == 0 || Password.Password.Length == 0)
            {
                var dialog = new MessageDialog("Greska: UserName ili Password polje prazno!");
                await dialog.ShowAsync();

            }
            else
            if (Username.Text == "admin" && Password.Password == "admin")
            {
                this.Frame.Navigate(typeof(AdminView));
            }
            else
            {
                var dialog = new MessageDialog("Greska: User nema pristup aplikaciji!");
                await dialog.ShowAsync();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
              
        }


        /* 
         za rad sa bazom, 
         1. napraviti klasu istoimena tabeli na bazi
         2. u klasu ubaciti getere i setere (mora id, jer se ne moze obrisati iz baze id kolona)
          3. u MAINPAGE moraaa biti ovo deklarisano ispod inaaačeee ne radiiiiii
          4. u adminview.xaml.cs dodana preostala potrebna implementacija
          
         */
        IMobileServiceTable<GbookAdmin> userTableObj1 = App.MobileService.GetTable<GbookAdmin>();


        
       // IMobileServiceTable<tabela> userTableObj = App.MobileService.GetTable<tabela>();
        private void btnSpasi_Tapped(object sender, TappedRoutedEventArgs e)
        {
            /*
            try

            {

                tabela obj = new tabela();
                obj.ime = txtIme.Text; obj.prezime = txtPrezime.Text; obj.indeks = txtIndeks.Text;
                userTableObj.InsertAsync(obj);

                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");
                msgDialog.ShowAsync();

            }

            catch (Exception ex)
            {

                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());

                msgDialogError.ShowAsync();
            }
            */
        }


    
        private void btnSpasi_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}




