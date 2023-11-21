using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esArticoli
{
    internal class ArticoloAlimentare : Articolo
    {
        private int _annoScadenza;
        public ArticoloAlimentare()
        {
            //attributi
            annoScadenza = 0;
        }
        public int annoScadenza
        {
            get { return _annoScadenza; }
            set { _annoScadenza = value; }
        }
    }
}

