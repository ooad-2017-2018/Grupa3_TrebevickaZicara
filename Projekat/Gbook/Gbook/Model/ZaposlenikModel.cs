using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
        class ZaposlenikModel
        {
         private int id;
            public OsobaINFOModel info;
            private DateTime datumZaposlenja;
            private double plata;
            private string tip_radnika; //portir, admin ili bibliotekar

        public ZaposlenikModel()
        {

        }

            public ZaposlenikModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email,string sifra,  DateTime datumZaposlenja, double plata, string tip)
            {

                info = new OsobaINFOModel(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, sifra);
                DatumZaposlenja = datumZaposlenja;
                Plata = plata;
                Tip_radnika = tip;

            }


        public ZaposlenikModel(int i, string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email, string sifra, DateTime datumZaposlenja, double plata, string tip)
        {
            Id = i;
            info = new OsobaINFOModel(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, sifra);
            DatumZaposlenja = datumZaposlenja;
            Plata = plata;
            Tip_radnika = tip;

        }
        public DateTime DatumZaposlenja { get => datumZaposlenja; set => datumZaposlenja = value; }
            public double Plata { get => plata; set => plata = value; }
        public string Tip_radnika { get => tip_radnika; set => tip_radnika = value; }
        public int Id { get => id; set => id = value; }

        /*
        public string DajImeZap() { return info.Ime; }
            public string DajPrezimeZap() { return info.Prezime; }

        */

        public Tuple<string, string> DajZaposlenika()
            {
                return new Tuple<string, string>(info.Ime, info.Prezime);
            }

            public Tuple<string, string> DajZaposlenika(string ime, string prezime)
            {
                return new Tuple<string, string>(ime, prezime);
            }
    


    /* class ZaposlenikModel
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


     */

}
}

