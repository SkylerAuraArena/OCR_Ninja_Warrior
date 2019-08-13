using System;

namespace OCR {
    class Program {
        static void Main(string[] args) {

            int nbTours = 1;
            int nbPoints = 0;
            Console.WriteLine("Lancement de Ninja Warrior Extreme Edition !!!");
            CJoueur guts = new CJoueur();
            guts.debut();
            int pv = guts.getPV;
            bool alive = guts.Alive;
            Console.WriteLine("Guts a encore " + pv + " pv restants !");
            if(alive == true) {
                Console.WriteLine("Je suis en vie !");
            }
            else {
                Console.WriteLine("Je suis mort !");
            }
            int de = CDe.LanceLeDe();
            Console.WriteLine("Voici le résulat du lancer de dé : " + de);


            while(guts.getPV > 0) {
                Console.WriteLine("Tour n°" + nbTours);
                Console.WriteLine("Il reste " + guts.getPV + " PV à Guts !");
                break;
            }

            Console.WriteLine("Snif, vous êtes mort...");
            Console.WriteLine("Bravo!!! Vous avez tué " + CMonstreFacile.nbMonstresFaciles + " monstres faciles et " + CMonstreDifficile.nbMonstresDifficiles + " monstres difficiles. Vous avez " + nbPoints + " points.");
            Console.WriteLine("GAME OVER !");
        }
    }
}