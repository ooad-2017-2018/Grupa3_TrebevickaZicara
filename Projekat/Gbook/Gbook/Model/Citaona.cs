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
    class Citaona
    {
        private string tipCitaone;
        private bool zauzeto;

        public Citaona(string tipCitaone, bool zauzeto)
        {
            this.tipCitaone = tipCitaone;
            this.zauzeto = zauzeto;
        }
    }
}
