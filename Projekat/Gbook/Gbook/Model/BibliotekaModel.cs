/*
 * created by:Mirela Dedic
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
        static class BibliotekaModel
        {

            private static List<ZaposlenikModel> zaposlenici = new List<ZaposlenikModel>();
            private static List<ClanModel> clanovi = new List<ClanModel>();
            private static List<KarticaModel> kartice = new List<KarticaModel>();
            private static List<KnjigaModel> knjige = new List<KnjigaModel>();
            private static List<CitaonaModel> citaone = new List<CitaonaModel>();

            public static void DodajClana(ClanModel clan)
            {
                clanovi.Add(clan);
            }
            public static void DodajKarticu(KarticaModel kartica)
            {
                kartice.Add(kartica);
            }
            public static void DodajKnjigu(KnjigaModel knjiga)
            {
                knjige.Add(knjiga);
            }
            public static void ObrisiKarticu(string ime, string prezime)
            {
                KarticaModel kartica = kartice.Find(delegate (KarticaModel k) { return k.Korisnik.Info.Ime == ime && k.Korisnik.Info.Prezime == prezime; });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji clan za brisanje!");
                }

                kartice.Remove(kartica);
            }
            public static void ObrisiClana(string ime, string prezime)
            {
                ClanModel cl = clanovi.Find(delegate (ClanModel c) { return c.DajClanIme() == ime && c.DajClanIme() == prezime; });
                if (cl == null)
                {
                    throw new Exception("Ne postoji clan za brisanje!");
                }

                clanovi.Remove(cl);
            }

            public static void ObrisiKnjigu(string naziv, string autor)
            {

                KnjigaModel knj = knjige.Find(delegate (KnjigaModel k) { return k.DajNaziv() == naziv && k.DajAutora() == autor; });
                if (knj == null)
                {
                    throw new Exception("Ne postoji knjiga za brisanje!");
                }

                knjige.Remove(knj);
            }
            public static bool OznaciIznajmljena(string naziv, string autor)
            {

                KnjigaModel knj = knjige.Find(delegate (KnjigaModel k) { return k.DajNaziv() == naziv && k.DajAutora() == autor; });
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
                return knjige;
            }
            public static List<KarticaModel> DajKartice()
            {
                return kartice;
            }
            public static KnjigaModel PretraziKnjige(string naziv, string autor)
            {

                KnjigaModel knj = knjige.Find(delegate (KnjigaModel k) { return k.DajAutora() == autor && k.DajNaziv() == naziv; });

                if (knj == null)
                {
                    throw new Exception("Ne postoji ta Knjiga u bazi podataka!");
                }

                return knj;
            }
            public static CitaonaModel PretraziCitaone(string tipCitaone)
            {
                //.. pronadji citaonu
                CitaonaModel citaona = citaone.Find(delegate (CitaonaModel c) { return c.DajTipCitaone() == tipCitaone; });
                if (citaona == null)
                {
                    throw new Exception("Ne postoji ta Citaona u bazi podataka!");
                }
                return citaona;
            }
            public static KarticaModel PretraziKartice(long idKartice)
            {
                KarticaModel kartica = kartice.Find(delegate (KarticaModel k) { return k.IdKartice == idKartice; });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji ta Kartica u bazi podataka!");
                }
                return kartica;
            }

            public static KarticaModel PretraziKarticuPoClanu(string ime, string prezime)
            {
                KarticaModel kartica = kartice.Find(delegate (KarticaModel k) { return k.DajKorisnikaKartice().Equals(new Tuple<string, string>(ime, prezime)); });
                if (kartica == null)
                {
                    throw new Exception("Ne postoji Kartica u bazi podataka!");
                }
                return kartica;
            }
            public static ClanModel PretrazoviClana(string ime, string prezime)
            {
                ClanModel cln = clanovi.Find(delegate (ClanModel c) { return c.DajClana().Equals(new Tuple<string, string>(ime, prezime)); });
                if (cln == null)
                {
                    throw new Exception("Ne postoje Clanovi (sa istim imenom i prezimenom) u bazi podataka !");
                }
                return cln;
            }
            public static List<ClanModel> IzvjestajClanovi()
            {
                return clanovi;
            }
            public static void DodajZaposlenika(ZaposlenikModel zap)
            {
                zaposlenici.Add(zap);
            }

            public static ZaposlenikModel DajZaposlenika(string ime, string prezime)
            {
                ZaposlenikModel zap = zaposlenici.Find(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime)); });
                if (zap == null)
                {
                    throw new Exception("Zaposlenik sa tim imenom ne postoji");
                }
                return zap;
            }
            public static List<ZaposlenikModel> PretraziZaposlenikeSaIstimImenomIPrezimenom(string ime, string prezime)
            {
                List<ZaposlenikModel> listazap = zaposlenici.FindAll(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime)); });
                if (listazap == null)
                {
                    throw new Exception("Ne postoje Zaposlenici (sa istim imenom i prezimenom) u bazi podataka !");
                }
                return listazap;
            }

            public static List<ZaposlenikModel> DajListuZaposlenika()
            {
                return zaposlenici;
            }

            /*public static void ObrisiZaposlenika(OsobaINFOModel info)
              {
                  ZaposlenikModel zap = zaposlenici.Find(delegate (ZaposlenikModel z) { return z.DajZaposlenika().Equals(new Tuple<string, string>(info.Ime, info.Prezime)); });
                  if (zap == null) { throw new Exception("Zaposlenik sa tim imenom nije upisan"); }
                  zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(new Tuple<string, string>(info.Ime, info.Prezime))));
              }*/

            public static void ObrisiZaposlenika(ZaposlenikModel zap)
            { // brise sve instance tog zaposlenika iz baze
                zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(zap)));
            }


            public static ZaposlenikModel ObrisiZaposlenika(string ime, string prezime)
            {
                ZaposlenikModel zap = zaposlenici.Find(delegate (ZaposlenikModel z) { return z.DajImeZap().Equals(ime) && z.DajPrezimeZap().Equals(prezime); });
                if (zap == null)
                {
                    throw new Exception("Zaposlenik sa tim imenom nije upisan");
                }
                zaposlenici.RemoveAll(x => (x.DajZaposlenika().Equals(new Tuple<string, string>(ime, prezime))));
                return zap;
            }
            public static void DodajCitaonu(CitaonaModel citaonica)
            {
                citaone.Add(citaonica);
            }

            public static List<CitaonaModel> IzvjestajCitaonaStandardna()
            {
                List<CitaonaModel> citaonica = citaone.FindAll(delegate (CitaonaModel c) { return c.DajTipCitaone() == "Standardna"; });
                if (citaonica == null)
                {
                    throw new Exception("Ne postoji Standardna Citaonica");
                }

                return citaonica;
            }
            public static List<CitaonaModel> IzvjestajCitaonaIstrazivacka()
            {
                List<CitaonaModel> citaonica = citaone.FindAll(delegate (CitaonaModel c) { return c.DajTipCitaone() == "Standardna"; });
                if (citaonica == null)
                {
                    throw new Exception("Ne postoji Istrazivacka Citaonica");
                }

                return citaonica;
            }
        }
    }


