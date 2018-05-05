﻿/*
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
    public class OsobaINFOModel
    {
        private string ime;
        private string prezime;
        private long jmbg;
        private DateTime datumRodjenja;
        private string grad;
        private string adresa;
        private long brojTel;
        private char spol;

        public OsobaINFOModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, char spol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.DatumRodjenja = datumRodjenja;
            this.Grad = grad;
            this.Adresa = adresa;
            this.BrojTel = brojTel;
            this.Spol = spol;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Grad { get => grad; set => grad = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public long BrojTel { get => brojTel; set => brojTel = value; }
        public char Spol { get => spol; set => spol = value; }
    }
}
