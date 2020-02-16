using System;
using System.Collections;
using System.Collections.Generic;

namespace ExerciciosBasicosCSharp
{
    static class Exercicio2
    {
        static int qtdEngenheiros = 75;
        static List<string> sistemas = new List<string>();
        static Hashtable vogais = new Hashtable();

        public static void Exercicio2Solucao()
        {
            vogais.Add('A', 1);
            vogais.Add('E', 2);
            vogais.Add('I', 3);
            vogais.Add('O', 5);
            vogais.Add('U', 8);

            sistemas.Add("SIRIUS");
            sistemas.Add("LALANDE");
            sistemas.Add("PROCION");
            sistemas.Add("ALPHA CENTAURI");
            sistemas.Add("BARNARD");

            foreach (string sistema in sistemas)
            {
                int produtoVogais = 1;

                foreach(char letra in sistema.ToString())
                {
                    if (vogais.Contains(letra))
                    {
                        produtoVogais = produtoVogais * Int32.Parse(vogais[letra].ToString());
                    }
                }

                Console.WriteLine("Sistema: " + sistema + " quantidade: " + produtoVogais);
                if (produtoVogais == qtdEngenheiros)
                    Console.WriteLine("Destino: " + sistema);
            }

            Console.Read();
        }
    }
}
