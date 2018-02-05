using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetlib
{
    public class Bil
    {
        private string _nummerplade;
        private DateTime _dato;
        private int _pris;
        private string _køretøj;

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
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }

    }
}
