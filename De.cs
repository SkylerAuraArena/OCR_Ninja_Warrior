using System;
using System.Collections.Generic;
using System.Text;

namespace OCR
{
    public class De {
        private Random random;

        public De() {
            random = new Random();
        }

        public int LanceLeDe() {
            return random.Next(1, 7);
        }
    }
}
