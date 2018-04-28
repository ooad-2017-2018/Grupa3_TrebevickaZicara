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
    class Kartica
    {
        private OsobaINFO info;
        private DateTime vaziDo;
        private long idKartice;

        public Kartica(OsobaINFO info, DateTime vaziDo, long idKartice)
        {
            this.info = info;
            this.vaziDo = vaziDo;
            this.idKartice = idKartice;
        }
    }
}
