using System;
using System.Collections.Generic;

namespace Recursivo
{
    class Program
    {
        static void Main2(string[] args)
        {
            int[] arrayNumeros = { 3, 2, 1, 7, 8, 9 };          
            inverterNumeros(arrayNumeros,0,arrayNumeros.Length-1);
            
            foreach(int i in arrayNumeros)
            {
                Console.WriteLine(i);
            }


        }

        private static void inverterNumeros(int[] arrayNumeros, int v1, int v2)
        {
            if (v1 < v2) { 
            trocarPosicao(arrayNumeros, v1, v2);
            inverterNumeros(arrayNumeros, v1+1, v2-1);
            }
        }

        private static void trocarPosicao(int[] arrayNumeros, int v1, int v2)
        {
            int aux = arrayNumeros[v1];
            arrayNumeros[v1] = arrayNumeros[v2];
            arrayNumeros[v2] = aux;
        }
    }
    
}
