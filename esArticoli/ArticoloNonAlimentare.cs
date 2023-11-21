using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esArticoli
{
    class ArticoloNonAlimentare : Articolo
    {
        private string _materiale;
        private bool _riciclabile;
        public ArticoloNonAlimentare()
        {
            //attributi
            materiale = "";
            riciclabile = false;
        }
        public string materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }
        public bool riciclabile
        {
            get { return _riciclabile; }
            set { _riciclabile = value; }
        }
    }
}
