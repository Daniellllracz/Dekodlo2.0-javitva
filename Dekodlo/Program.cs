using System;
using System.Collections.Generic;
using System.IO;

namespace Dekodlo
{
    class Program
    {
        static void Main(string[] args)
        {
            var karakterek = new List<Karakter>();
            var sr = new StreamReader(
                path: @"..\..\..\src\bank.txt",
                encoding: System.Text.Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                char b = char.Parse(sr.ReadLine());
                bool[,] m = new bool[7, 4];
                for (int s = 0; s < 7; s++)
                {
                    string sor = sr.ReadLine();
                    for (int o = 0; o < sor.Length; o++)
                    {
                        m[s, o] = sor[0] == '1';

                    }
                }
                karakterek.Add(new Karakter(b, m));
            }
            Console.WriteLine($"karakterek száma: {karakterek.Count}");
            char input = '\0';
            bool res = false;
            do
            {
                Console.WriteLine("input:");
                res = char.TryParse(Console.ReadLine(), out input);
            } while(!res || (input < 65 || input > 90));
            {

            }
        }
    }
}
