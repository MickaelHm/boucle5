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
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            int indexer;
            for (indexer = 0; indexer < 7; indexer++)
            {
                Console.WriteLine(week[indexer]);
            }
        }
    }
}
