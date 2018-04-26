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
    class Zaposlenik
    {
        private OsobaINFO info;
        private DateTime datumZaposlenja;
        private double plata;

        public Zaposlenik(OsobaINFO info, DateTime datumZaposlenja, double plata)
        {
            this.info = info;
            this.datumZaposlenja = datumZaposlenja;
            this.plata = plata;
        }
    }
}
