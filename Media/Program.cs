using System;
using System.Collections.Generic;
using System.Linq;
namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Program b = new Program();
                List<int> lista_de_elementos = new List<int>();
                lista_de_elementos.Add(8);
                lista_de_elementos.Add(4);
                lista_de_elementos.Add(10);
                lista_de_elementos.Add(4);
                
                b.elemnto(lista_de_elementos);
              
                
            }           
        }

       private Double mediaArt(List<int> lista_de_elementos, int tamanhoLista)
        {
            if (lista_de_elementos.Count == 0)
            {
                return 0;
            }
           
            Double media = Convert.ToDouble(lista_de_elementos[0]) / tamanhoLista + mediaArt(lista_de_elementos.Skip(1).Take(lista_de_elementos.Count).ToList(), tamanhoLista);          
            return media;          
        }

        private void elemnto(List<int> lista_de_elementos)
        {
            Double media = mediaArt(lista_de_elementos, lista_de_elementos.Count);
            int total = 0;
            foreach(int valor in lista_de_elementos)
            {
                if (Convert.ToDouble(valor) > media)
                    total++;
            }
            Console.WriteLine("A media eh de:" + media + " e existe "+total+" elementos maiores que a media");
        }
    }
}
