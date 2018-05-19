using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gbook.Model;
using Gbook.View;

namespace Gbook.ViewModel
{
    class LogInViewModel
    {
        public void provjera (Login forma)
        {
            //if (forma.textBoxIme.Text == "admin" && forma.passwordBoxSifra.Password == "admin")
                forma.Frame.Navigate(typeof(AdminView));
        }
    }
}
