﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCR {
    public class MonstreDifficile : MonstreFacile {
        private const int degatsSort = 5;

        public override void Attaque(Joueur joueur) {
            base.Attaque(joueur);
            joueur.SubitDegats(SortMagique());
        }

        private int SortMagique() {
            int valeur = De.LanceLeDe();
            if (valeur == 6)
                return 0;
            return degatsSort * valeur;
        }
    }
}
