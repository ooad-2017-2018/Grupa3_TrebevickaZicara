using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbook.Model
{
    class PrijavaModel
    {
        private string user;
        private string password;
        public static bool prijavljen = false;
        public static bool ulogiran = false;
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        public void PrijaviSe()
        {
            string username = "";
            string password = "";
            if (!prijavljen)
            {
                //username = Console.ReadLine();
                //password = Console.ReadLine();
            }
            if ((username == "admin" && password == "admin") || prijavljen)
            {
                prijavljen = true;
            }
        }

        public void RegistrujSe()
        {
        }
        public string PromijeniLozinku(string novaLozinka)
        {
            password = novaLozinka;
            return password;
        }

        public void KreirajSifruKorisnika()
        {

        }
        public static void Izlaz()
        {
            //Console.WriteLine("Dovidjenja");
            return;
        }
    }
}
    


