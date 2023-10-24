using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue: Primero en entrar primero en salir, aparece tal y como esta escrito
          Queue<CPunto> puntos = new Queue<CPunto>();

            puntos.Enqueue(new CPunto(1, 2));
            puntos.Enqueue(new CPunto(7, 4));
            puntos.Enqueue(new CPunto(2, 9));
            puntos.Enqueue(new CPunto(5, 3));

            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------------------------------------------------------");

            // Hacemos un Peek
            Console.WriteLine("Peek {0}", puntos.Peek());
            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------------------------------------------------------");

            // Dequeue: toma y saca los elementos, lo mismo que el Pop del stack
            Console.WriteLine("Dequeue {0}", puntos.Dequeue());
            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------------------------------------------------------");

            // hacemos peek para prueba
            Console.WriteLine("Peek {0}", puntos.Peek());
            foreach (var p in puntos)
            {
                Console.WriteLine("->{0}", p);
            }

            Console.WriteLine("-----------------------------------------------------------");






        }
       
    }
}
