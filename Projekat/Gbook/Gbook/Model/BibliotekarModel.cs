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
        public BibliotekarModel(OsobaINFOModel info, DateTime datumZaposlenja, double plata) : base(info, datumZaposlenja, plata)
        {
            clanovi = new List<ClanModel>();
            knjige = new List<KnjigaModel>();
        
        }

    }
}

