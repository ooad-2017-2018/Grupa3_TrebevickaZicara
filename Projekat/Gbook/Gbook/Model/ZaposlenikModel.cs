using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class ZaposlenikModel
    {
        private OsobaINFOModel info;
        private DateTime datumZaposlenja;
        private double plata;
        
        public ZaposlenikModel(OsobaINFOModel info, DateTime datumZaposlenja, double plata)
        {
            this.info = info;
            this.datumZaposlenja = datumZaposlenja;
            this.plata = plata;
        }

        public DateTime DatumZaposlenja { get; set; }
        public double Plata { get; set;  }
    }
}

