using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAdaptador
{
    //Interfaz que conoce el cliente
    internal interface ITarget
    {
        int Sumar(int pA, int pB);
        int Restar(int pA, int pB);
        int Multiplicar(int pA, int pB);
        int Dividir(int pA, int pB);
    }
}
