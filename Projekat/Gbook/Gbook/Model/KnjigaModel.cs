
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
            private readonly long ISBN;
            private DateTime godinaIzdanja;
            private int naStanju;
            private Boolean zaduzena;
            private ClanModel clan;

            public KnjigaModel(string naziv, string autor, string izdavac, long isbn, DateTime godinaIzdanja, int naStanju, bool zaduzena)
            {
                this.Naziv = naziv;
                this.Autor = autor;
                this.Izdavac = izdavac;
                this.ISBN = isbn;
                this.GodinaIzdanja = godinaIzdanja;
                this.NaStanju = naStanju;
                this.Zaduzena = zaduzena;

            }

        public KnjigaModel(string naziv, string autor, long isbn, DateTime godinaIzdanja, int naStanju)
        {
            this.Naziv = naziv;
            this.Autor = autor;
        
            this.ISBN = isbn;
            this.GodinaIzdanja = godinaIzdanja;
            this.NaStanju = naStanju;
           

        }

        public KnjigaModel(string naziv, string autor, ClanModel clan)
            {
                this.Naziv = naziv;
                this.Autor = autor;
                this.clan = clan;
            }
            public string DajNaziv()
            {
                return naziv;
            }

            public string DajAutora()
            {
                return autor;
            }

            public string Naziv { get => naziv; set => naziv = value; }
            public string Autor { get => autor; set => autor = value; }
            public string Izdavac { get => izdavac; set => izdavac = value; }
            public DateTime GodinaIzdanja { get => godinaIzdanja; set => godinaIzdanja = value; }
            public int NaStanju { get => naStanju; set => naStanju = value; }
            public bool Zaduzena { get => zaduzena; set => zaduzena = value; }

   

    /* class KnjigaModel
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
             this.Naziv = naziv;
             this.Autor = autor;
             this.Izdavac = izdavac;
             ISBN1= iSBN;
             this.GodinaIzdanja = godinaIzdanja;
             this.NaStanju = naStanju;
             this.Zaduzena = zaduzena;
         }

         public void Azuriraj(string naziv, string autor, string izdavac, long iSBN, DateTime godinaIzdanja, int naStanju, bool zaduzena)
         {
             Naziv = naziv;
             Autor = autor;
             Izdavac = izdavac;
             ISBN1 = iSBN;
             GodinaIzdanja = godinaIzdanja;
             NaStanju = naStanju;
             Zaduzena = zaduzena;
         }

         public string Naziv { get => naziv; set => naziv = value; }
         public string Autor { get => autor; set => autor = value; }
         public string Izdavac { get => izdavac; set => izdavac = value; }
         public long ISBN1{ get => ISBN; set => ISBN = value; }
         public DateTime GodinaIzdanja { get => godinaIzdanja; set => godinaIzdanja = value; }
         public int NaStanju { get => naStanju; set => naStanju = value; }
         public bool Zaduzena { get => zaduzena; set => zaduzena = value; }
         */
}
}

