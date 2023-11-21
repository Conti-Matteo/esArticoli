using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esArticoli
{
    class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _giorniDopoApertura;
        public ArticoloAlimentareFresco()
        {
            //attributi
            giorniDopoApertura = 0;
        }
        public int giorniDopoApertura
        {
            get { return _giorniDopoApertura; }
            set { _giorniDopoApertura = value; }
        }
    }
}
