using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esArticoli
{
    internal class Articolo
    {
        private string _codice;
        private string _descrizione;
        private double _prezzoUnitario;
        private bool _cartaFedeltà;
        public Articolo()
        {
            //attributi
            _codice = "";
            _descrizione = "";
            _prezzoUnitario = 0;
            _cartaFedeltà = false;
        }
        public string codice
        {
            get { return _codice; }
            set { _codice = value; }
        }
        public string descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }
        public double prezzoUnitario
        {
            get { return _prezzoUnitario; }
            set { _prezzoUnitario = value; }
        }
        public bool cartaFedeltà
        {
            get { return _cartaFedeltà; }
            set { _cartaFedeltà = value; }
        }
    }
}

