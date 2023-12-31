﻿using esArticoli;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Classe_articoli
{
    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {
        private int _prefCons;

        public int PrefCons
        {
            get { return _prefCons; }
            set { _prefCons = value; }
        }

        public ArticoloAlimentareFresco() : base()
        {
            PrefCons = 3;
        }

        public ArticoloAlimentareFresco(int prefCons, int anno, int codice, string descrizione, double prezzoUnitario, bool cartaFedeltà) : base(anno, codice, descrizione, prezzoUnitario, cartaFedeltà)
        {
            PrefCons = prefCons;
        }

        public ArticoloAlimentareFresco(ArticoloAlimentareFresco vecchioArtAlimFre, ArticoloAlimentare vecchioArtAlim, Articolo vecchioArt) : base(vecchioArtAlim, vecchioArt)
        {
            PrefCons = vecchioArtAlimFre.PrefCons;
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Consumarsi entro: {PrefCons}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ArticoloAlimentareFresco other = (ArticoloAlimentareFresco)obj;

            if (base.Equals(other) && PrefCons == other.PrefCons)
            {
                return true;
            }

            return false;
        }

        public override double Sconta()
        {
            double perc = 10F;
            double cliente = base.Sconta();

            for (int i = 1; i < 6 && i < PrefCons; i++)
            {
                perc -= 2F;
            }

            return cliente - cliente * perc / 100;
        }
    }
}