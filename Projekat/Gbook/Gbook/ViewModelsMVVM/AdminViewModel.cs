using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Gbook.ViewModelsMVVM;

namespace Gbook.ViewModelsMVVM
{
    public class AdminViewModel : INotifyPropertyChanged
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
        string upisanoIme, upisanoPrezime, upJmbg, upDatum, upBTel, upGrad, upAdresa, upEmail, validationText;

        ICommand dodajZap, ponistiZap, dodajSlZap, ponistiSlZap;
        public string UpisanoIme
        {
            get => upisanoIme;
            set
            {
                upisanoIme = value;
                OnPropertyChanged("UpisanoIme");
            }

        }

        public string UpisanoPrezime
        {
            get => upisanoPrezime;
            set { upisanoPrezime = value; OnPropertyChanged("UpisanoPrezime"); }
        }
        public string ValidationText { get => validationText; set { validationText = value; OnPropertyChanged("ValidationText"); } }

        public string UpEmail { get => upEmail; set { upEmail = value; OnPropertyChanged("UpEmail"); } }

        public string UpAdresa
        {
            get => upAdresa; set { upAdresa = value; OnPropertyChanged("UpAdresa"); }
        }
        public string UpGrad { get => upGrad; set { upGrad = value; OnPropertyChanged("UpGrad"); } }
        public string UpBTel { get => upBTel; set { upBTel = value; OnPropertyChanged("UpBTel"); } }

        public string UpDatum { get => upDatum; set { upDatum = value; OnPropertyChanged("UpDatum"); } }

        public string UpJmbg { get => upJmbg; set { upJmbg = value; OnPropertyChanged("UpJmbg"); } }



        public ICommand PonistiZap { get => ponistiZap; set => ponistiZap = value; }
        public ICommand DodajSlZap { get => dodajSlZap; set => dodajSlZap = value; }
        public ICommand PonistiSlZap { get => ponistiSlZap; set => ponistiSlZap = value; }
        public ICommand DodajZap { get => dodajZap; set => dodajZap = value; }

        // public AdminModel Admin { get; set; }
        public AdminViewModel()
        {
            ValidationText = "";
            UpisanoIme = "";
            UpisanoPrezime = "";
            UpJmbg = "";
            UpDatum = "";
            UpBTel = "";
            UpGrad = "";
            UpAdresa = "";
            UpEmail = "";

          //  DodajSlZap = new RelayCommand<object>(exeDodajSliku, canexeDodajSliku);
           // PonistiSlZap = new RelayCommand<object>(exePonistiSliku, canexePonistiSliku);
          //  DodajZap = new RelayCommand<object>(exeDodajZap, canexeDodajZap);
          //  PonistiZap = new RelayCommand<object>(exePonistiZap, canexePonistiZap);
            //   Admin = new AdminModel();
        }

    }
}
