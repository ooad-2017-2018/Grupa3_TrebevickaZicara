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
    class BibliotekaModel
    {
        public List<ZaposlenikModel> zaposlenici;
        private List<ClanModel> clanovi;
        private List<KarticaModel> kartice;
        private List<KnjigaModel> knjige;
        private List<CitaonaModel> citaone;

        public BibliotekaModel()
        {
            zaposlenici = new List<ZaposlenikModel>();
            clanovi = new List<ClanModel>();
            kartice = new List<KarticaModel>();
            knjige = new List<KnjigaModel>();
            citaone = new List<CitaonaModel>();
        }
    }
}
