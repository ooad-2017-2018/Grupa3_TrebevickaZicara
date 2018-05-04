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
            this.Info = info;
            this.Kategorija = kategorija;
            this.DatumUclanjenja = datumUclanjenja;
            this.VaziDo = vaziDo;
            Knjige = new List<KnjigaModel>();
        }

        public OsobaINFOModel Info { get => info; set => info = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }
        public DateTime DatumUclanjenja { get => datumUclanjenja; set => datumUclanjenja = value; }
        public DateTime VaziDo { get => vaziDo; set => vaziDo = value; }
        internal List<KnjigaModel> Knjige { get => knjige; set => knjige = value; }

        public void Azuriraj(OsobaINFOModel info, string kategorija, DateTime datumUclanjenja, DateTime vaziDo)
        {
            Info = info;
            Kategorija = kategorija;
            DatumUclanjenja = datumUclanjenja;
            VaziDo = vaziDo;
        }
    }
}

