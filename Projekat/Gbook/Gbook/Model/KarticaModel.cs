
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
        class KarticaModel
        {
        static int id = 1;
            private DateTime vaziDo;
            private long idKartice;
            private ClanModel korisnik;
           // private BibliotekarModel bibliotekar; o
           //ovo nam ne treba



            public DateTime VaziDo { get => vaziDo; set => vaziDo = value; }
            public long IdKartice { get => idKartice; set => idKartice = value; }
            internal ClanModel Korisnik { get => korisnik; set => korisnik = value; }

            public KarticaModel(DateTime vaziDo,  ClanModel clan)
            {
                this.VaziDo = vaziDo;
                this.IdKartice = id;
                     id++;
                this.Korisnik = clan;
                
            }
            public DateTime DatumVazenjaKartice()
            {
                return vaziDo;
            }

            public ClanModel DajKorisnikaKartice()
            {
                return Korisnik;
            }

        /*
        public BibliotekarModel DajBibliotekaraKojiJeIzdaoKarticu()
            {
                return bibliotekar;
            }
        */
    
    }

}
