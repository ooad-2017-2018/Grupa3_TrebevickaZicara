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
    class Portir : Zaposlenik
    {
        private List<Clan> clanovi;
        private List<Citaona> citaone;
        public Portir(OsobaINFO info, DateTime datumZaposlenja, double plata) : base(info, datumZaposlenja, plata) {
            clanovi = new List<Clan>();
            citaone = new List<Citaona>();
        }
    }
}
