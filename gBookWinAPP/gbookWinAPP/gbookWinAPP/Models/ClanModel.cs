using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gbookWinAPP.Models
{
    public class ClanModel
    {
        [Required]
        public string clanID {get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        

        private long jmbg;
        private DateTime datumRodjenja;
        private string grad;
        private string adresa;
        private long brojTel;
        private string email;
    }
}