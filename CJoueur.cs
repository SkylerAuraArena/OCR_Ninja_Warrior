using System;
using System.Collections.Generic;
using System.Text;

namespace OCR {
    class CJoueur {
        private int pv;
        private bool alive;

        public CJoueur() {
            pv = 150;
            alive = true;
        }

        public int getPV { get => pv; }
        public bool Alive { get => alive; }

        public void debut() {
            Console.WriteLine("Je suis en piste avec " + this.pv + " pv !");
        }

        public void Attaque(CMonstre monstre) {

        }

        public void SubitDegats(int degatSubits) {

        }
    }
}
