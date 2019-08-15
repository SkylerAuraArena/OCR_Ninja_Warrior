﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCR {
    public class Joueur {
        public int PtsDeVies { get; private set; }
        public bool EstVivant {
            get { return PtsDeVies > 0; }
        }

        public Joueur(int points) {
            PtsDeVies = points;
        }

        public void Attaque(MonstreFacile monstre) {
            int lanceJoueur = LanceLeDe();
            int lanceMonstre = monstre.LanceLeDe();
            if (lanceJoueur >= lanceMonstre)
                monstre.SubitDegats();
        }

        public void Attaque(BossDeFin boss) {
            int nbPoints = LanceLeDe(26);
            boss.SubitDegats(nbPoints);
        }

        public int LanceLeDe() {
            return De.LanceLeDe();
        }

        public int LanceLeDe(int valeur) {
            return De.LanceLeDe(valeur);
        }

        public void SubitDegats(int degats) {
            if (!BouclierFonctionne())
                PtsDeVies -= degats;
        }

        private bool BouclierFonctionne() {
            return De.LanceLeDe() <= 2;
        }
    }
}
