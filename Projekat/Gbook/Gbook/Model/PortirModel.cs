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
    class PortirModel : ZaposlenikModel
    {
        private List<ClanModel> clanovi;
        private List<CitaonaModel> citaone;
        public PortirModel(BibliotekaModel b, OsobaINFOModel info, DateTime datumZaposlenja, double plata) : base(b, info, datumZaposlenja, plata)
        {
            clanovi = new List<ClanModel>();
            citaone = new List<CitaonaModel>();
        }
    }
}
