using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetlib
{
    class Mc
    {
        private string _nummerplade;
        private DateTime _dato;


        public string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = Nummerplade; }

        }
        //property
        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = Dato; }
        }

        //methode
        public int BilletPris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "Mc";
        }
    }
}
