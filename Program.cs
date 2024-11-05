using Terrain_;
using System;

namespace ExempleTerrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terrain UnTerrain = new Terrain("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Terrain UnAutreTerrain = new Terrain("138 Rue de Bordeaux, 16000 Angoulême", 3385.95f, 4, true);
            Terrain UnDernierTerrain = new Terrain("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Terrain[] CatalogueMaisons = new Terrain[] { UnTerrain, UnAutreTerrain, UnDernierTerrain };

            foreach (Terrain M in CatalogueMaisons)
            {
                Console.WriteLine(M);
            }
        }
    }
}
