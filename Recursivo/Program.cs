using System;
using System.Collections.Generic;

namespace Recursivo
{
    class Program
    {
        static void Main (string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(3);
            lista.Add(2);
            lista.Add(1);
            lista.Add(7);
            lista.Add(8);
            lista.Add(9);
            lista.Add(5);

                
            Console.Write("Lista => ");
            foreach (int i in lista)
            {
                Console.Write("[" + i + "]");
            }
            inverterNumeros(lista,0,lista.Count-1);
            //Console.WriteLine();
            Console.Write("\nLista Invertida => ");
            foreach (int i in lista)
            {
                Console.Write("["+i+"]");
            }


        }

        private static void inverterNumeros(List<int> lista, int v1, int v2)
        {
            if (v1 < v2) { 
            trocarPosicao(lista, v1, v2);
            inverterNumeros(lista, v1+1, v2-1);
            }
        }

        private static void trocarPosicao(List<int> lista, int v1, int v2)
        {
            int aux = lista[v1];
            lista[v1] = lista[v2];
            lista[v2] = aux;
        }
    }
    
}
