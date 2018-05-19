using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Gbook.Model
{
    class IskaznicaModel
    {
       
        ZaposlenikModel zaposlenik;
        string naziv;
        string tip;
        BitmapImage slika;

        public IskaznicaModel(ZaposlenikModel zaposlenik, BitmapImage slika)
        {
            this.zaposlenik = zaposlenik;
            this.naziv = zaposlenik.info.Ime+" "+zaposlenik.info.Prezime;
            this.tip = zaposlenik.Tip_radnika;
            this.slika = slika;
        }

        public IskaznicaModel(ZaposlenikModel zaposlenik)
        {
            this.zaposlenik = zaposlenik;
            this.naziv = zaposlenik.info.Ime + " " + zaposlenik.info.Prezime;
            this.tip = zaposlenik.Tip_radnika;
            
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Tip { get => tip; set => tip = value; }
        public BitmapImage Slika { get => slika; set => slika = value; }
        internal ZaposlenikModel Zaposlenik { get => zaposlenik; set => zaposlenik = value; }
    }
}
