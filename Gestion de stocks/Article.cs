using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace GestionDeStocks
{
    class Article
    {
        public uint numeroDeReference { get; set; }
        public string nom { get; set; }
        public float prixDeVente { get; set; }
        public byte quantiteEnStock { get; set; }

        // définition du constructeur
        public Article (uint numeroDeReference, string nom, float prixDeVente, byte quantiteEnStock)
            
        {
            this.numeroDeReference = numeroDeReference;
            this.nom = nom;
            this.prixDeVente = prixDeVente;
            this.quantiteEnStock = quantiteEnStock;

        }

    }
}
