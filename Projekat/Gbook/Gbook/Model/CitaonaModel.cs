using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class CitaonaModel
    {
        private string tipCitaone;
        private bool zauzeto;

        public CitaonaModel(string tipCitaone, bool zauzeto)
        {
            this.tipCitaone = tipCitaone;
            this.zauzeto = zauzeto;
           
        }
    }
}
