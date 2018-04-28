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
    class Biblioteka
    {
        private List<Zaposlenik> zaposlenici;
        private List<Clan> clanovi;
        private List<Kartica> kartice;
        private List<Knjiga> knjige;
        private List<Citaona> citaone;
        
        public Biblioteka()
        {
            zaposlenici = new List<Zaposlenik>();
            clanovi = new List<Clan>();
            kartice = new List<Kartica>();
            knjige = new List<Knjiga>();
            citaone = new List<Citaona>();
        }

        public void DodajZaposlenika(Bibliotekar b) { }
        public void DodajZaposlenika(Portir p) { }
        public Zaposlenik PretraziZaposlenika(Zaposlenik z) { return 0;  }
        public void IzvjestajZaposlenici() { }
        public void KreirajSifruKorisnika(){  }




    }
}
