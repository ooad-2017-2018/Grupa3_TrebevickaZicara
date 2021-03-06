﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 using Windows.UI.Xaml.Media.Imaging;

namespace Gbook.Model
{
        class OsobaINFOModel
        {
            private string ime;
            private string prezime;
            private long jmbg;
            private DateTime datumRodjenja;
            private string grad;
            private string adresa;
            private long brojTel;
            private string email;
            private string sifra;
           private BitmapImage slika;


            public OsobaINFOModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email, string sifraa)
            {
                this.Ime = ime;
                this.Prezime = prezime;
                this.Jmbg = jmbg;
                this.DatumRodjenja = datumRodjenja;
                this.grad = grad;
                this.adresa = adresa;
                this.brojTel = brojTel;
                this.email = email;
            this.sifra = sifraa;

            }

        //konstruktor za člana ne koristi sve info moguće
        public OsobaINFOModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string adresa, long brojTel,  string sifraa)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
            this.DatumRodjenja = datumRodjenja;
            
            this.adresa = adresa;
            this.brojTel = brojTel;
           
            this.sifra = sifraa;

        }



        public OsobaINFOModel(string ime, string prezime, string sifra)
            {
                this.Ime = ime;
                this.Prezime = prezime;
            Sifra = sifra;

            }
            public string Ime
            {
                get
                {
                    return ime;
                }
                set
                {
                    if (value.Length > 20)
                        throw new Exception("Greska: Ime nije validno");
                    else ime = value;
                }
            }
            public string Prezime
            {
                get
                {
                    return prezime;
                }
                set
                {
                    if (value.Length > 20)
                        throw new Exception("Greska: Prezime nije validno");
                    else prezime = value;
                }
            }
            public DateTime DatumRodjenja
            {
                set
                {
                    if (value.CompareTo(DateTime.Now) > 0)
                        throw new Exception("Greska: Datum nije validan");
                    else datumRodjenja = value;
                }
                get
                {
                    return datumRodjenja;
                }
            }

        public string Sifra { get => sifra; set => sifra = value; }
        public BitmapImage Slika { get => slika; set => slika = value; }
        public long Jmbg { get => jmbg; set => jmbg = value; }


        public string to_String()
        {
            return "Ime: " + Ime + "\nPrezime: " + Prezime + "\nJMBG: " + Jmbg + "\nGrad: " + grad + "\nBroj telefona: " + brojTel + "\n";
        }
        /* public class OsobaINFOModel
         {
             private string ime;
             private string email;
             private string prezime;
             private long jmbg;
             private DateTime datumRodjenja;
             private string grad;
             private string adresa;
             private long brojTel;

             public string Ime { get => ime; set => ime = value; }
             public string Email { get => email; set => email = value; }
             public string Prezime { get => prezime; set => prezime = value; }
             public long Jmbg { get => jmbg; set => jmbg = value; }
             public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
             public string Grad { get => grad; set => grad = value; }
             public string Adresa { get => adresa; set => adresa = value; }
             public long BrojTel { get => brojTel; set => brojTel = value; }

             public OsobaINFOModel(string ime, string emaill,  string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel)
             {
                 this.Ime = ime;
                 this.Prezime = prezime;
                 this.Jmbg = jmbg;
                 this.DatumRodjenja = datumRodjenja;
                 this.Grad = grad;
                 this.Adresa = adresa;
                 this.BrojTel = brojTel;
                 this.Email = emaill;

             }

             public OsobaINFOModel(string ime, string prezime, long jmbg, DateTime datumRodjenja,  string adresa, long brojTel)
             {
                 this.Ime = ime;
                 this.Prezime = prezime;
                 this.Jmbg = jmbg;
                 this.DatumRodjenja = datumRodjenja;

                 this.Adresa = adresa;
                 this.BrojTel = brojTel;


             }
     */
    }
}
