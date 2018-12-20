using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };//création du tableau
            int indexer;
            for (indexer = 0; indexer < 7; indexer++)//variable, condition, incrémentation | dans ce genre de ligne, on peut utiliser i a la place d'indexer ou autre mot
          //for (indexer = 0; indexer < week.Length; indexer++) week.Lenght indique comme condition que la boucle doit arriver jusqu'a la fin du tableau
            {
                Console.WriteLine(week[indexer]);
            }
        }
    }
}
