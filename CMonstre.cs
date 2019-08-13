using System;
using System.Collections.Generic;
using System.Text;

namespace OCR {
    public abstract class CMonstre {

        private bool alive;

        public CMonstre() {
            alive = true;
        }

        protected bool Alive { get => alive; }
        
        public virtual void Attaque() {

        }
    }
}
