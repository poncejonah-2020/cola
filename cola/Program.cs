using System;
using System.Collections.Generic;

namespace cola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos una cola
            Queue<int> numeros = new Queue<int>();

            //Agregamos elementos a la cola
            numeros.Enqueue(1);
            numeros.Enqueue(2);
            numeros.Enqueue(3);
            numeros.Enqueue(4);
            numeros.Enqueue(5);

            //Recorriendo la cola
            Console.WriteLine("Recorremos la cola por 1ra vez");

            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }

            //Eliminando elemento de la cola
            numeros.Dequeue();

            //Recorriendo la cola
            Console.WriteLine("Recorremos la cola con el elemento eliminado");
            foreach (int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }

        }
    }
}
