﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCR
{
    public static class De {
        private static Random random = new Random();

        public static int LanceLeDe() {
            return random.Next(1, 7);
        }

        public static int LanceLeDe(int valeur) {
            return random.Next(1, valeur);
        }
    }
}