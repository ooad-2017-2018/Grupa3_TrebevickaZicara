using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gbook.ViewModelsMVVM
{
   public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        List<String> lista = new List<string> { "Administrator", "Bibliotekar", "Portrir" };

        ICommand zaPrijavu;
        string validationText, username, password;

        public string Username
        {
            get => username;
            set { username = value; ValidationText = " "; OnPropertyChanged("Username"); }
        }
        public string Password
        {
            get => password;
            set { password = value; ValidationText = " "; OnPropertyChanged("Password"); }
        }
        public string ValidationText
        {
            get => validationText;
            set { validationText = value; OnPropertyChanged("ValidationText"); }
        }

        public ICommand ZaPrijavu { get => zaPrijavu; set => zaPrijavu = value; }



        //...KONSTRUKTOR
        public MainPageViewModel()
        {
            ValidationText = "";
            Username = "";
            Password = "";
            ZaPrijavu = new RelayCommand<object>(funkcijaPrijava, funPrijava);
        }

        void funkcijaPrijava(object parametar)
        {
            if (Username.Equals("admin") && Password.Equals("admin")) { ValidationText = " "; }
            else { ValidationText = "Greska Prijava!"; }
        }

        bool funPrijava(object parametar)
        {
            return true;
        }
    }
}
