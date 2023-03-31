using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alfabet = new int[27];
            int inc = 97;

            Console.WriteLine(args.Length);
            //creez un vector cu literele alfabetului
            for (int i = 0; i < alfabet.Length; i++)
            {
                if ((i + 1) >= alfabet.Length)
                {
                    break;
                }
                alfabet[i + 1] = inc;
                inc++;

            }
            for (int i = 0; i < alfabet.Length; i++)
            {
                Console.Write((char)alfabet[i] + " ");
            }

            Console.WriteLine();
            //creez o lista care contine o lista cu cuvinte si aloc 27 de spatii
            List<List<string>> cuvinte = new List<List<string>>();
            cuvinte.Add(new List<string>());
            for (int i = 0; i < 27; i++)
            {
                cuvinte.Add(new List<string>());
            }

            //pentru fiecare cuvant din linia de comanda il voi adauga in lista creeata pe pozitia echivalenta pozitiei din vectorul de litere
            //adica verific daca indexul primei litere este egal cu indexul unei litere din vectorul alfabet
            for (int i = 0; i < args.Length; i++)
            {
                string token = args[i].ToLower();
                cuvinte[Array.IndexOf(alfabet, (int)token[0])].Add(args[i]);

            }

            for (int i = 1; i < cuvinte.Count; i++)
            {
                if (cuvinte[i].Count == 0)
                {
                    continue;
                }
                for (int j = 0; j < cuvinte[i].Count; j++)
                {
                    Console.Write((char)alfabet[i] + ": " + cuvinte[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
