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
        class KarticaModel
        {
            private DateTime vaziDo;
            private long idKartice;
            private ClanModel korisnik;
            private BibliotekarModel bibliotekar;



            public DateTime VaziDo { get => vaziDo; set => vaziDo = value; }
            public long IdKartice { get => idKartice; set => idKartice = value; }
            internal ClanModel Korisnik { get => korisnik; set => korisnik = value; }

            public KarticaModel(DateTime vaziDo, long idKartice, ClanModel clan, BibliotekarModel bibliotekar)
            {
                this.VaziDo = vaziDo;
                this.IdKartice = idKartice;
                this.Korisnik = clan;
                this.bibliotekar = bibliotekar;
            }
            public DateTime DatumVazenjaKartice()
            {
                return vaziDo;
            }

            public ClanModel DajKorisnikaKartice()
            {
                return Korisnik;
            }

            public BibliotekarModel DajBibliotekaraKojiJeIzdaoKarticu()
            {
                return bibliotekar;
            }
        
    
    }

}
