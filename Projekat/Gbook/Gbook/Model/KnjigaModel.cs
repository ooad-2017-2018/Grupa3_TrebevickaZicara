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
    class KnjigaModel
    {
        private string naziv;
        private string autor;
        private string izdavac;
        private long ISBN;
        private DateTime godinaIzdanja;
        private int naStanju;
        private Boolean zaduzena;

        public KnjigaModel(string naziv, string autor, string izdavac, long iSBN, DateTime godinaIzdanja, int naStanju, bool zaduzena)
        {
            this.naziv = naziv;
            this.autor = autor;
            this.izdavac = izdavac;
            ISBN = iSBN;
            this.godinaIzdanja = godinaIzdanja;
            this.naStanju = naStanju;
            this.zaduzena = zaduzena;
        }
    }
}

