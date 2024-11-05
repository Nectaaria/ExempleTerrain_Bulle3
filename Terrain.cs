using System;
using System.Text.RegularExpressions;

namespace Terrain_
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesClotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbCotesClotures, bool riviere)
        {
            Adresse = adresse;
            Superficie = superficie;
            NbCotesClotures = nbCotesClotures;
            Riviere = riviere;
        }

        public override string ToString()
        {
            string toString = String.Format("Adresse = {0}\n", this.Adresse);
            toString += String.Format("Superficie = {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de côtés cloturés = {0}\n", this.NbCotesClotures);
            toString += String.Format("Présence d'une rivière = {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> VALEUR = {0}$", this.EvaluationValeur());
            return toString;
        }

        public float EvaluationValeur()
        {
            int facteur = 3000;
            if (this.Riviere) { facteur += 500; }
            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }
            return (this.Superficie * facteur) - CoutFinirCloture();
        }

        public int CoutFinirCloture()
        {
            int cout = 0;
            if (this.NbCotesClotures < 3) { cout += 100 * (3 - NbCotesClotures); }
            return cout;
        }
    }
}
