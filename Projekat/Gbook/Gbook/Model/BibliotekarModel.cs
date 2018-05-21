
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class BibliotekarModel : ZaposlenikModel
    {
 public BibliotekarModel()
        {

        }
      //MEDINA -> ovo nije uvezano sa Bibliotekom,kada dodas clana ili bilo sta,nece se azurirati lista clanova u Biblioteci  
        /*
      
        public void DodajClana(string ime, string prezime, long jmbg, DateTime datumRodjenja, string adresa, long brojTel, string kategorija, DateTime datumUclanjenja, DateTime vaziDo)
        {
            clanovi.Add(new ClanModel(new OsobaINFOModel(ime, prezime, jmbg, datumRodjenja, adresa, brojTel), kategorija, datumUclanjenja, vaziDo));
        }


        public void ObrisiClana(string ime, string prezime)
        {

            foreach (ClanModel i in clanovi)
                if (i.Info.Ime == ime && i.Info.Prezime == prezime)
                { clanovi.Remove(i); break; }


        }

        public void AzurirajClana(string ime, string prezime, long jmbg, DateTime datumRodjenja, string adresa, long brojTel, string kategorija, DateTime datumUclanjenja, DateTime vaziDo)
        {
            foreach (ClanModel i in clanovi)
                if (i.Info.Ime == ime && i.Info.Prezime == prezime && i.Info.Jmbg==jmbg)
                {
                    i.Azuriraj(new OsobaINFOModel(ime, prezime, jmbg, datumRodjenja, adresa, brojTel), kategorija, datumUclanjenja, vaziDo);
                }
            
        }


        public void DodajKnjigu(string naziv, string autor, string izdavac, long iSBN, DateTime godinaIzdanja, int naStanju, bool zaduzena)
        {
            knjige.Add(new KnjigaModel(naziv, autor, izdavac, iSBN, godinaIzdanja, naStanju, zaduzena));
        }


      

        public void ObrisiKnjigu(string naziv, string autor, string izdavac, long iSBN, DateTime godinaIzdanja, int naStanju, bool zaduzena)
        {
            foreach(KnjigaModel i in knjige)
                if(i.Naziv==naziv && i.ISBN1==iSBN)
                { knjige.Remove(i); break; }

        }

        public void AzurirajKnjigu(string naziv, string autor, string izdavac, long iSBN, DateTime godinaIzdanja, int naStanju, bool zaduzena)
        {
            foreach (KnjigaModel i in knjige)
                if (i.Naziv == naziv && i.ISBN1 == iSBN)
                {
                    i.Azuriraj(naziv,autor, izdavac, iSBN, godinaIzdanja, naStanju, zaduzena);
                }
        }
        */
            public BibliotekarModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email, string sifra, DateTime datumZaposlenja, double plata, string tip) 
            : base(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, sifra, datumZaposlenja, plata, tip)
            {

            }
        /*
            public void DodajClana(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email,string sifra, string kategorija, DateTime datumUclanjenja)
            {
                OsobaINFOModel info = new OsobaINFOModel(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, sifra);
                BibliotekaModel.DodajClana(new ClanModel(info, kategorija, datumUclanjenja, null, this));

            }
            */

            public void DodajKarticu(DateTime vaziDo,  ClanModel clan)
            {
                BibliotekaModel.DodajKarticu(new KarticaModel(vaziDo, clan));

            }

            //..Ako Bibliotekar DodajeKnjigu
            public void DodajKnjigu(string naziv, string autor, string izdavac, long isbn, DateTime godinaIzdanja, int naStanju, bool zaduzena)
            {
                BibliotekaModel.DodajKnjigu(new KnjigaModel(naziv, autor, izdavac, isbn, godinaIzdanja, naStanju, zaduzena));
            }

            public void ObrisiClana(ClanModel clan)
            {
                BibliotekaModel.ObrisiClana(clan.Info.Ime, clan.Info.Prezime);
            }

            public bool IznajmiKnjigu(KnjigaModel knj)
            {
                return BibliotekaModel.OznaciIznajmljena(knj.Naziv, knj.Autor);
            }

            public void ObrisiKnjigu(KnjigaModel knj)
            {
                BibliotekaModel.ObrisiKnjigu(knj.DajNaziv(), knj.DajAutora());
            }

            public void ObrisiKarticu(string ime, string prezime)
            {
                BibliotekaModel.ObrisiKarticu(ime, prezime);
            }

            /*  public void ObrisiKarticu(KarticaModel k)
              {
                  BibliotekaModel.ObrisiKarticu(k.Korisnik.Info.Ime,k.Korisnik.Info.Prezime);
              }
            */

            public void ObrisiKarticu(ClanModel clan)
            {
                BibliotekaModel.ObrisiKarticu(clan.Info.Ime, clan.Info.Prezime);
            }



            public void IsteklaKartica(ClanModel clan, KarticaModel k)
            {
                if (clan.DajIDKartice().Equals(k.IdKartice) && k.DatumVazenjaKartice() < DateTime.Today)
                {
                    //.. obrisi clana iz sistema,ako ne plati clanarinu,provjeri ima li iznajmljenih knjiga kod njega koje nije vratio
                    BibliotekaModel.ObrisiClana(clan.Info.Ime, clan.Info.Prezime);
                }

            }




        }
    }


