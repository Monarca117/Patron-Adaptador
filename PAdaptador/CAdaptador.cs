using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAdaptador
{
    //El adaptador comunica al cliente con la clase que se adapta
    internal class CAdaptador : ITarget
    {
        CCalculadoraArray adaptado = new CCalculadoraArray();

        public int Dividir(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envían
            int[] operadores = { pA, pB };

            //Realizamos las operaciones del adaptado
            r = adaptado.div(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        public int Multiplicar(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envían
            int[] operadores = { pA, pB };

            //Realizamos las operaciones del adaptado
            r = adaptado.multi(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        public int Restar(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envían
            int[] operadores = { pA, pB };

            //Realizamos las operaciones del adaptado
            r = adaptado.resta(operadores);

            //Adaptamos el resultado
            return (int)r;
        }

        //Aquí hacemos la adaptación de una operación
        public int Sumar(int pA, int pB)
        {
            double r = 0;

            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envían
            int[] operadores = { pA, pB };

            //Realizamos las operaciones del adaptado
            r = adaptado.suma(operadores);

            //Adaptamos el resultado
            return (int)r;
        }
    }
}
