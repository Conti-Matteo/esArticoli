using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class Articolo
    {
        private int _codice;
        private string _descrizione;
        private double _prezzoUnitario;
        private bool _cartaFedeltà;

        public int Codice
        {
            get { return _codice; }
            set { _codice = value.GetHashCode(); }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public double PrezzoUnitario
        {
            get { return _prezzoUnitario; }
            set { _prezzoUnitario = value; }
        }

        public bool CartaFedeltà
        {
            get { return _cartaFedeltà; }
            set { _cartaFedeltà = value; }
        }

        public Articolo()
        {
            Codice = 0;
            Descrizione = "";
            PrezzoUnitario = 0;
            CartaFedeltà = false;
        }

        public Articolo(int codice, string descrizione, double prezzoUnit, bool cartaFed)
        {
            Codice = codice;
            Descrizione = descrizione;
            PrezzoUnitario = prezzoUnit;
            CartaFedeltà = cartaFed;
        }

        public Articolo(Articolo vecchioArt)
        {
            Codice = vecchioArt.Codice;
            Descrizione = vecchioArt.Descrizione;
            PrezzoUnitario = vecchioArt.PrezzoUnitario;
            CartaFedeltà = vecchioArt.CartaFedeltà;
        }

        public override string ToString()
        {
            string str = CartaFedeltà ? "Abbonato" : "Non abbonato";
            return $"Codice: {Codice}; Descrizione: {Descrizione}; Prezzo Unitario: {PrezzoUnitario}; Carta Fedeltà: {str}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Articolo other = (Articolo)obj;

            if (Codice == other.Codice && Descrizione == other.Descrizione && PrezzoUnitario == other.PrezzoUnitario && CartaFedeltà == other.CartaFedeltà)
            {
                return true;
            }

            return false;
        }

        public virtual double Sconta()
        {
            if (CartaFedeltà)
            {
                return PrezzoUnitario - PrezzoUnitario * 5 / 100;
            }

            return PrezzoUnitario;
        }
    }
}