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
        class PortirModel : ZaposlenikModel
        {

            public PortirModel(string ime, string prezime, long jmbg, DateTime datumRodjenja, string grad, string adresa, long brojTel, string email, DateTime datumZaposlenja, double plata) : base(ime, prezime, jmbg, datumRodjenja, grad, adresa, brojTel, email, datumZaposlenja, plata)
            { }


            public void DodajKorisnikaCItaoniceUSistem(KarticaModel kartica, ClanModel clan)
            {

            }
            public void IzdajSjediste()
            {

            }
            public void IzdajBrojCitaone()
            {

            }




            /*  class PortirModel : ZaposlenikModel
              {
                  private List<ClanModel> clanovi;
                  private List<CitaonaModel> citaone;
                  public PortirModel(BibliotekaModel b, OsobaINFOModel info, DateTime datumZaposlenja, double plata) : base(b, info, datumZaposlenja, plata)
                  {
                      clanovi = new List<ClanModel>();
                      citaone = new List<CitaonaModel>();
                  }
                  }
                  */
        
    }
}
