using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAdaptador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este es el cliente

            int resultado = 0;
            int op = 0;

            //Usamos la interfaz que el cliente conoce con la clase que conoce
            ITarget calcu = new CCalcu();

            //Pregunta por operación
            Console.WriteLine(@"¿Qué operación desea ejecutar?
1.Suma
2.Resta
3.Multiplicación
4.División
");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                resultado = calcu.Sumar(4, 3);
                Console.WriteLine("El resultado es {0}", resultado);

                Console.WriteLine("--------------");

                //Hacemos uso del adaptador
                calcu = new CAdaptador();

                //Usamos el adaptador para hacer la operacion
                resultado = calcu.Sumar(15, 6);

                Console.WriteLine("El resultado es {0}", resultado);
            }
            
            if (op == 2) 
            {
                resultado = calcu.Restar(8, 3);
                Console.WriteLine("El resultado es {0}", resultado);

                Console.WriteLine("--------------");

                //Hacemos uso del adaptador
                calcu = new CAdaptador();

                //Usamos el adaptador para hacer la operacion
                resultado = calcu.Restar(16, 6);

                Console.WriteLine("El resultado es {0}", resultado);
            }

            if (op == 3)
            {
                resultado = calcu.Multiplicar(5, 3);
                Console.WriteLine("El resultado es {0}", resultado);

                Console.WriteLine("--------------");

                //Hacemos uso del adaptador
                calcu = new CAdaptador();

                //Usamos el adaptador para hacer la operacion
                resultado = calcu.Multiplicar(10, 6);

                Console.WriteLine("El resultado es {0}", resultado);
            }

            if (op == 4)
            {
                resultado = calcu.Dividir(10, 2);
                Console.WriteLine("El resultado es {0}", resultado);

                Console.WriteLine("--------------");

                //Hacemos uso del adaptador
                calcu = new CAdaptador();

                //Usamos el adaptador para hacer la operacion
                resultado = calcu.Dividir(20, 5);

                Console.WriteLine("El resultado es {0}", resultado);
            }
        }
    }
}
