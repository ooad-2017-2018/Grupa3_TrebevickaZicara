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
    public class OsobaINFO
    {
        private string ime;
        private string prezime;
        private long jmbg;
        private DateTime datumRodjenja;
        private string grad;
        private string adresa;
        private long brojTel;
        private char spol;

        public  OsobaINFO(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datumRodjenja = datumRodjenja;
            this.grad = grad;
            this.adresa = adresa;
            this.brojTel = brojTel;
            this.spol = spol;
        }
    }
}
