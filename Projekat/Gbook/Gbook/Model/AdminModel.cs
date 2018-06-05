using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;


namespace Gbook.Model
{
        class AdminModel
        {
            private string user;
            private string pw;

            public AdminModel(string user = "admin", string pw = "admin")
            {
                this.user = user;
                this.pw = pw;
            }

            public void DodajZaposlenika(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email, string sifra, DateTime datumZaposlenja, double plata, string tip)
            {
                BibliotekaModel.DodajZaposlenika(new ZaposlenikModel(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, sifra, datumZaposlenja, plata, tip));
            }


        




        public ZaposlenikModel DajZaposlenika(string ime, string prezime)
            {
                return BibliotekaModel.DajZaposlenika(ime, prezime);
            }
            public List<ZaposlenikModel> PretraziZaposlenikeSaIstimImenomIPrezimenom(string ime, string prezime)
            {
                return BibliotekaModel.PretraziZaposlenikeSaIstimImenomIPrezimenom(ime, prezime);
            }
            public List<ZaposlenikModel> DajListuZaposlenika()
            {
                return BibliotekaModel.DajListuZaposlenika();
            }

            public ZaposlenikModel ObrisiZaposlenika(string ime, string prezime)
            {
                //...vrati obrisanog zaposlenika
                return BibliotekaModel.ObrisiZaposlenika(ime, prezime);
            }

            public void ObrisiZaposlenika(ZaposlenikModel zap)
            {
                BibliotekaModel.ObrisiZaposlenika(zap);
            }

            public void DodajCitaonu(string tipCitaone, bool zauzeta = false)
            {
                CitaonaModel citaonica = new CitaonaModel(tipCitaone, zauzeta);
                BibliotekaModel.DodajCitaonu(citaonica);
            }

            public List<CitaonaModel> ListaCitaonicaStandarnih()
            {
                return BibliotekaModel.IzvjestajCitaonaStandardna();
            }

            public List<CitaonaModel> ListaCitaonicaIstrazivackih()
            {
                return BibliotekaModel.IzvjestajCitaonaIstrazivacka();
            }

            public ClanModel PronadjiClana(string ime, string prezime)
            {
                return BibliotekaModel.PretrazoviClana(ime, prezime);
            }

            public List<ClanModel> IzvjestajClanovi()
            {
                return BibliotekaModel.IzvjestajClanovi();
            }

            public List<KnjigaModel> IzvjestajKnjige()
            {
                return BibliotekaModel.Knjige;
            }
            public List<KarticaModel> IzvjestajKartice()
            {
                return BibliotekaModel.Kartice;
            }


        }
}
