/*
 * created by:Mirela Dedic
 * created on: 26.04.2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class BibliotekarModel : ZaposlenikModel
    {
        private List<ClanModel> clanovi;
        private List<KnjigaModel> knjige;
        public BibliotekarModel(BibliotekaModel b, OsobaINFOModel info, DateTime datumZaposlenja, double plata) : base(b, info, datumZaposlenja, plata)
        {
            clanovi = new List<ClanModel>();
            knjige = new List<KnjigaModel>();
        }
      
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

        public void AzuirajClana(string ime, string prezime, long jmbg, DateTime datumRodjenja, string adresa, long brojTel, string kategorija, DateTime datumUclanjenja, DateTime vaziDo)
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


    }
}

