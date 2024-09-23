﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAdaptador
{
    internal class CCalcu : ITarget
    {
        public int Dividir(int pA, int pB)
        {
            return pA / pB;
        }

        public int Multiplicar(int pA, int pB)
        {
            return pA * pB;
        }

        public int Restar(int pA, int pB)
        {
            return pA - pB;
        }

        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
    }
}
