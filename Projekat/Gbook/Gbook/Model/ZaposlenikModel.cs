using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class ZaposlenikModel
    {
        private BibliotekaModel biblioteka;
        private OsobaINFOModel info;
        private DateTime datumZaposlenja;
        private double plata;

        internal BibliotekaModel Biblioteka { get => biblioteka; set => biblioteka = value; }
        public OsobaINFOModel Info { get => info; set => info = value; }
        public DateTime DatumZaposlenja { get => datumZaposlenja; set => datumZaposlenja = value; }
        public double Plata { get => plata; set => plata = value; }

        public ZaposlenikModel(BibliotekaModel bibliotek, OsobaINFOModel info, DateTime datumZaposlenja, double plata)
        {
            this.Biblioteka = bibliotek;
            this.Info = info;
            this.DatumZaposlenja = datumZaposlenja;
            this.Plata = plata;
            
        }


        public void Azuriraj(BibliotekaModel bibliotek, OsobaINFOModel info, DateTime datumZaposlenja, double plata){
            this.Biblioteka = bibliotek;
            this.Info = info;
            this.DatumZaposlenja = datumZaposlenja;
            this.Plata = plata;
        }

        public void DodajZaposlenog(BibliotekaModel bibliotek, OsobaINFOModel info, DateTime datumZaposlenja, double plata)
        {
            Biblioteka.zaposlenici.Add(new ZaposlenikModel(bibliotek, info, datumZaposlenja, plata));
        }
        
        public void ObrisiZaposlenog (string ime, string prezime, long jmbg)
        { 
           foreach(ZaposlenikModel i in Biblioteka.zaposlenici)
            if(i.Info.Ime ==ime && i.Info.Prezime==prezime && i.Info.Jmbg==jmbg)
            Biblioteka.zaposlenici.Remove(i);
        }

        public void AzurirajZaposlenog(BibliotekaModel bibliotek, OsobaINFOModel info, DateTime datumZaposlenja, double plata)
        {
            foreach (ZaposlenikModel i in Biblioteka.zaposlenici)
                if (i.Info.Ime == info.Ime && i.Info.Prezime == info.Prezime && i.Info.Jmbg == info.Jmbg)
                    i.Azuriraj(bibliotek, info, datumZaposlenja, plata);
        }




    }
}

