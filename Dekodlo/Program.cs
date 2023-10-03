using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dekodlo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new List<Karakter>();
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
                        m[s, o] = sor[o] == '1';

                    } 
                }
                bank.Add(new Karakter(b, m));
            }
            Console.WriteLine($"karakterek száma: {bank.Count}");
            char input = '\0';
            bool res = false;
            do
            {
                Console.WriteLine("input:");
                res = char.TryParse(Console.ReadLine(), out input);
            } while(!res || (input < 65 || input > 90));
            {

            }
            var megj = bank.SingleOrDefault(k => k.Betu == input);
            if (megj is not null) Console.Write(megj.Kirajzol());
            else Console.WriteLine("nincsen ilyen a bankban");
        }
    }
}
