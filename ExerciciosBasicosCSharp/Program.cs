using System;
using System.Collections;

namespace ExerciciosBasicosCSharp
{
    class Program
    {
        static Hashtable listaNumerosLetras = new Hashtable();
        static Hashtable listaCometasCores = new Hashtable();

        static void Main(string[] args)
        {
            listaNumerosLetras.Add('A', 1);
            listaNumerosLetras.Add('B', 2);
            listaNumerosLetras.Add('C', 3);
            listaNumerosLetras.Add('D', 4);
            listaNumerosLetras.Add('E', 5);
            listaNumerosLetras.Add('F', 6);
            listaNumerosLetras.Add('G', 7);
            listaNumerosLetras.Add('H', 8);
            listaNumerosLetras.Add('I', 9);
            listaNumerosLetras.Add('J', 10);
            listaNumerosLetras.Add('K', 11);
            listaNumerosLetras.Add('L', 12);
            listaNumerosLetras.Add('M', 13);
            listaNumerosLetras.Add('N', 14);
            listaNumerosLetras.Add('O', 15);
            listaNumerosLetras.Add('P', 16);
            listaNumerosLetras.Add('Q', 17);
            listaNumerosLetras.Add('R', 18);
            listaNumerosLetras.Add('S', 19);
            listaNumerosLetras.Add('T', 20);
            listaNumerosLetras.Add('U', 21);
            listaNumerosLetras.Add('V', 22);
            listaNumerosLetras.Add('W', 23);
            listaNumerosLetras.Add('X', 24);
            listaNumerosLetras.Add('Y', 25);
            listaNumerosLetras.Add('Z', 26);

            listaCometasCores.Add("HALLEY", "AMARELO");
            listaCometasCores.Add("ENCKE", "VERMELHO");
            listaCometasCores.Add("WOLF", "PRETO");
            listaCometasCores.Add("KUSHIDA", "AZUL");

            // Se o resto da divisão do número do grupo por 45 for igual ao resto da divisão do número do cometa por 45, então o grupo será levado.
            foreach (DictionaryEntry cometaCor in listaCometasCores)
            {
                int cometaResult = 1;
                int cometaResto = -1;
                int corResult = 1;
                int corResto = -2;

                foreach (char letraCometa in cometaCor.Key.ToString())
                {
                    cometaResult = cometaResult * Int32.Parse(listaNumerosLetras[letraCometa].ToString());
                }
                cometaResto = cometaResult % 45;

                foreach (char letraCor in cometaCor.Value.ToString())
                {
                    corResult = corResult * Int32.Parse(listaNumerosLetras[letraCor].ToString());
                }
                corResto = corResult % 45;

                if (cometaResto != corResto)
                    Console.WriteLine("=====> NAO Serah levado: " + cometaCor.Value);
            }

            Console.ReadKey();
        }
    }
}
