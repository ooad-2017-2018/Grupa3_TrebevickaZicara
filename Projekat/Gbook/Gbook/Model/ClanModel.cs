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
    class ClanModel
    {
        private OsobaINFOModel info;
        private string kategorija;
        private DateTime datumUclanjenja;
        private DateTime vaziDo;
        private List<KnjigaModel> knjige;
        public ClanModel(OsobaINFOModel info, string kategorija, DateTime datumUclanjenja, DateTime vaziDo)
        {
            this.info = info;
            this.kategorija = kategorija;
            this.datumUclanjenja = datumUclanjenja;
            this.vaziDo = vaziDo;
            knjige = new List<KnjigaModel>();
        }
    }
}

