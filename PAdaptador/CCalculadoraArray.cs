using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAdaptador
{
    //Esta es la clase que deseamos adaptar, el cliente no la puede usar directamente pues su interfaz es diferente.
    internal class CCalculadoraArray
    {
        public double suma(int[] pOperandos)
        {
            int n = 0;
            double r = 0;

            for(n = 0 ; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;
        }

        public double resta(int[] pOperandos)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;
        }

        public double multi(int[] pOperandos)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;
        }

        public double div(int[] pOperandos)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];

            return r;
        }
    }
}
