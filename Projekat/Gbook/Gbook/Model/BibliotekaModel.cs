
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
        static class BibliotekaModel
        {

            private static List<ZaposlenikModel> zaposlenici= new List<ZaposlenikModel>();
     
        private static List<ClanModel> clanovi = new List<ClanModel>();
            private static List<KarticaModel> kartice = new List<KarticaModel>();
            private static List<KnjigaModel> knjige = new List<KnjigaModel>();
            private static List<CitaonaModel> citaone = new List<CitaonaModel>();
        private static List<IskaznicaModel> iskaznice = new List<IskaznicaModel>();

        
        internal static List<ClanModel> Clanovi { get => clanovi; set => clanovi = value; }
        internal static List<KarticaModel> Kartice { get => kartice; set => kartice = value; }
        internal static List<KnjigaModel> Knjige { get => knjige; set => knjige = value; }
        internal static List<CitaonaModel> Citaone { get => citaone; set => citaone = value; }
        internal static List<ZaposlenikModel> Zaposlenici { get => zaposlenici; set => zaposlenici = value; }
        internal static List<IskaznicaModel> Iskaznice { get => iskaznice; set => iskaznice = value; }

        public static void NapuniInfo()
        {
            zaposlenici.Add(new ZaposlenikModel("Admin", "A", 1605996175068, new DateTime(16 / 05 / 1996), "Sarajevo", "Zmaja od Bosne bb", 62123123, "medii_mail.com", "sifra", new DateTime(10 / 10 / 2010), 1500, "admin"));
            zaposlenici.Add(new ZaposlenikModel("Bibliotekar", "B", 1705996175068, new DateTime(16 / 05 / 1994), "Sarajevo", "Kodzina bb", 62123123, "rambo_mail.com", "sifra", new DateTime(10 / 10 / 2015), 1500, "bibliotekar"));
            zaposlenici.Add(new ZaposlenikModel("Portir", "P", 1605996175068, new DateTime(16 / 05 / 1996), "Sarajevo", "Zmaja od Bosne bb", 62123123, "medii_mail.com", "sifra", new DateTime(10 / 10 / 2010), 1500, "portir"));
            clanovi.Add(new ClanModel(new OsobaINFOModel("Clan", "daci", "sifra"), "student", new DateTime(14 / 02 / 2018), new KarticaModel(new DateTime(),  new ClanModel()), new BibliotekarModel()));


        }


        public static void DodajClana(ClanModel clan)
            {
                Clanovi.Add(clan);
            }
            public static void DodajKarticu(KarticaModel kartica)
            {
                Kartice.Add(kartica);
            }
            public static void DodajKnjigu(KnjigaModel knjiga)
            {
                Knjige.Add(knjiga);
            }

            public static void ObrisiKarticu(string ime, string prezime)
            {
                KarticaModel kartica = Kartice.Find(delegate (KarticaModel k) { return k.Korisnik.Info.Ime == ime && k.Korisnik.Info.Prezime == prezime; });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji clan za brisanje!");
                }

                Kartice.Remove(kartica);
            }

            public static void ObrisiClana(string ime, string prezime)
            {
                ClanModel cl = Clanovi.Find(delegate (ClanModel c) 
                { return c.DajClanIme() == ime && c.DajClanIme() == prezime; });
                if (cl == null)
                {
                    throw new Exception("Ne postoji clan za brisanje!");
                }

                Clanovi.Remove(cl);
            }

            public static void ObrisiKnjigu(string naziv, string autor)
            {

                KnjigaModel knj = Knjige.Find(delegate (KnjigaModel k) { return k.DajNaziv() == naziv && k.DajAutora() == autor; });
                if (knj == null)
                {
                    throw new Exception("Ne postoji knjiga za brisanje!");
                }
       
                Knjige.Remove(knj);
            }
            public static bool OznaciIznajmljena(string naziv, string autor)
            {

                KnjigaModel knj = Knjige.Find(delegate (KnjigaModel k) { return k.DajNaziv() == naziv && k.DajAutora() == autor; });
                if (knj == null)
                {
                    return false;
                }
                return true;
            }

            /* public List<BibliotekarModel> DajBibliotekare()
             {
                 return zaposlenici.FindAll(delegate (ZaposlenikModel z) { return "BibliotekarModel" == z.GetType().Name; }).ConvertAll(x => (BibliotekarModel)x);
             }

             public List<PortirModel> DajSvePortire()
             {
                 return zaposlenici.FindAll(delegate (ZaposlenikModel z) { return "PortirModel" == z.GetType().Name; }).ConvertAll(x => (PortirModel)x);
             }
             */
            public static List<KnjigaModel> DajKnjige()
            {
                return Knjige;
            }

            public static List<KarticaModel> DajKartice()
            {
                return Kartice;
            }

            public static KnjigaModel PretraziKnjige(string naziv, string autor)
            {

                KnjigaModel knj = Knjige.Find(delegate (KnjigaModel k) { return k.DajAutora() == autor && k.DajNaziv() == naziv; });

                if (knj == null)
                {
                    throw new Exception("Ne postoji ta Knjiga u bazi podataka!");
                }

                return knj;
            }

            public static CitaonaModel PretraziCitaone(string tipCitaone)
            {
                //.. pronadji citaonu
                CitaonaModel citaona = Citaone.Find(delegate (CitaonaModel c) { return c.DajTipCitaone() == tipCitaone; });
                if (citaona == null)
                {
                    throw new Exception("Ne postoji ta Citaona u bazi podataka!");
                }
                return citaona;
            }

            public static KarticaModel PretraziKartice(long idKartice)
            {
                KarticaModel kartica = Kartice.Find(delegate (KarticaModel k) { return k.IdKartice == idKartice; });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji ta Kartica u bazi podataka!");
                }
                return kartica;
            }

            public static KarticaModel PretraziKarticuPoClanu(string ime, string prezime)
            {
                KarticaModel kartica = Kartice.Find(delegate (KarticaModel k) { return k.DajKorisnikaKartice().Equals(new Tuple<string, string>(ime, prezime)); });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji Kartica u bazi podataka!");
                }
                return kartica;
            }

            public static ClanModel PretrazoviClana(string ime, string prezime)
            {
                ClanModel cln = Clanovi.Find(delegate (ClanModel c) { return c.DajClana().Equals(new Tuple<string, string>(ime, prezime)); });
                if (cln == null)
                {
                    throw new Exception("Ne postoje Clanovi (sa istim imenom i prezimenom) u bazi podataka !");
                }
                return cln;
            }

            public static List<ClanModel> IzvjestajClanovi()
            {
                return Clanovi;
            }

       public static void DodajZaposlenika(ZaposlenikModel z)
        {
            BibliotekaModel.Zaposlenici.Add(z);
        }

     

        public static ZaposlenikModel DajZaposlenika(string ime, string prezime)
            {
                ZaposlenikModel zap = Zaposlenici.Find(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime)); });
                if (zap == null)
                {
                    throw new Exception("Zaposlenik sa tim imenom ne postoji");
                }
                return zap;
            }

            public static List<ZaposlenikModel> PretraziZaposlenikeSaIstimImenomIPrezimenom(string ime, string prezime)
            {
                List<ZaposlenikModel> listazap = Zaposlenici.FindAll(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime)); });
                if (listazap == null)
                {
                    throw new Exception("Ne postoje Zaposlenici (sa istim imenom i prezimenom) u bazi podataka !");
                }
                return listazap;
            }

            public static List<ZaposlenikModel> DajListuZaposlenika()
            {
                return Zaposlenici;
            }

            /*public static void ObrisiZaposlenika(OsobaINFOModel info)
              {
                  ZaposlenikModel zap = zaposlenici.Find(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(info.Ime, info.Prezime)); });
                  if (zap == null) { throw new Exception("Zaposlenik sa tim imenom nije upisan"); }
                  zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(new Tuple<string, string>(info.Ime, info.Prezime))));
              }*/

            public static void ObrisiZaposlenika(ZaposlenikModel zap)
            { // brise sve instance tog zaposlenika iz baze
                Zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(zap)));
            }


            public static ZaposlenikModel ObrisiZaposlenika(string ime, string prezime)
            {
                ZaposlenikModel zap = Zaposlenici.Find(delegate (ZaposlenikModel z) { return z.info.Ime.Equals(ime) && z.info.Prezime.Equals(prezime); });
                if (zap == null)
                {
                    throw new Exception("Zaposlenik sa tim imenom nije upisan");
                }
                Zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime))));
                return zap;
            }

            public static void DodajCitaonu(CitaonaModel citaonica)
            {
                Citaone.Add(citaonica);
            }

            public static List<CitaonaModel> IzvjestajCitaonaStandardna()
            {
                List<CitaonaModel> citaonica = Citaone.FindAll(delegate (CitaonaModel c) { return c.DajTipCitaone() == "Standardna"; });
                if (citaonica == null)
                {
                    throw new Exception("Ne postoji Standardna Citaonica");
                }

                return citaonica;
            }

            public static List<CitaonaModel> IzvjestajCitaonaIstrazivacka()
            {
                List<CitaonaModel> citaonica = Citaone.FindAll(delegate (CitaonaModel c) { return c.DajTipCitaone() == "Standardna"; });
                if (citaonica == null)
                {
                    throw new Exception("Ne postoji Istrazivacka Citaonica");
                }

                return citaonica;
            }
        }
    }


