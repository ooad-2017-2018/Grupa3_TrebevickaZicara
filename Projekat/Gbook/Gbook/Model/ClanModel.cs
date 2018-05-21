
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class ClanModel
        {
            public OsobaINFOModel info;
            //private string kategorija;
            private DateTime datumUclanjenja;
            private KarticaModel kartica;
            private List<KnjigaModel> knjige;
         //   private BibliotekarModel mojBibliotekar; nebitno je ko ga je dodao

        public ClanModel()
        {

        }

            public ClanModel(OsobaINFOModel info,  DateTime datumUclanjenja)
            {
                this.Info = info;
               // this.kategorija = kategorija;
                this.datumUclanjenja = datumUclanjenja;
               // this.Kartica = kartica;
                knjige = new List<KnjigaModel>();
               // mojBibliotekar = bibliotekar;
            }

            internal OsobaINFOModel Info { get => info; set => info = value; }
        internal KarticaModel Kartica { get => kartica; set => kartica = value; }

        public long DajIDKartice()
            {
                return Kartica.IdKartice;
            }
            public string DajClanIme()
            {
                return info.Ime;
            }

            public string DajClanPrezime()
            {
                return info.Prezime;
            }

            public Tuple<string, string> DajClana()
            {
                return new Tuple<string, string>(info.Ime, info.Prezime);
            }

            public List<KnjigaModel> PregledajKnjige()
            {
                return knjige;
            }
            public void IznajmiKnjiguClan(string naziv, string autor)
            {
                KnjigaModel knjiga = new KnjigaModel(naziv, autor, this);
                //bool iz = mojBibliotekar.IznajmiKnjigu(knjiga);
               // if (iz) knjige.Add(knjiga);
            }

            /* zaduzeneknjige clana,datum vracanja knjige,datum uzimanja knjige  plati clanarinu*/
    

    /* class ClanModel
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
         */
}
}

