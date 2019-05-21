using System;
using System.Collections.Generic;


namespace Recursivo
{
    class Reverse
    {
        static void Main(string[] args)
        {
            List<int> Lista_de_inteiros = new List<int>();

            Lista_de_inteiros.Add(10);
            Lista_de_inteiros.Add(9);
            Lista_de_inteiros.Add(8);
            Lista_de_inteiros.Add(7);
            Lista_de_inteiros.Add(6);
            Lista_de_inteiros.Add(5);

            Console.WriteLine("Lista");
            foreach (int numero in Lista_de_inteiros)
            {
                Console.Write("["+numero+"]");
            }

            Lista_de_inteiros.Reverse();
            Console.WriteLine();
            Console.WriteLine("Lista invertida");
            foreach (int numero in Lista_de_inteiros)
            {
                Console.Write("[" + numero + "]");
            }
        }
    }
}
