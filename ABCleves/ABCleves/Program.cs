using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCleves
{
    class Program
    {
        public enum Betuk { a = 1, á, b, c, d, e, é, f, g, h, i, í, j, k, l, m,
            n, o, ó, ö, ő, p, q, r, s, t, u, ú, ü, ű, v, w, x, y, z, ß } //Magyar ABC megoldás
        static void Main(string[] args)
        {
            Console.Write("Kérem a szót: ");
            string bemeno = Console.ReadLine();
            Szoveg szoveg = new Szoveg(bemeno);
            Console.WriteLine($"A szót ábécé sorrendben: {Sorrendbe_1(bemeno)}");//ASCII code megoldás
            Console.WriteLine($"A szót ábécé sorrendben: {Sorrendbe_2(bemeno)}");//Magyar ABC megoldás
            Console.WriteLine($"A szót ábécé sorrendben: {szoveg.Sorrendbe_2()}");//Magyar ABC megoldás Osztály meg.
            Console.ReadLine();
        }
        static string Sorrendbe_1(string bemeno)//ASCII code megoldás
        {
            char[] tomb = bemeno.ToCharArray();
            Array.Sort(tomb);

            return new string(tomb);

        }
        static string Sorrendbe_2(string bemeno)//Magyar ABC megoldás
        {
            string kimeno = "ß";
            for(int i=0; i<bemeno.Length; i++)
            {
                Betuk be;
                Enum.TryParse(bemeno[i].ToString(), true, out be);
                for(int j=0; j<kimeno.Length; j++)
                {
                    Betuk ki;
                    Enum.TryParse(kimeno[j].ToString(), true, out ki);
                    if ((int)be<(int)ki)
                    {
                        kimeno = String.Concat(kimeno.Substring(0, j), bemeno[i], kimeno.Substring(j));
                        break;
                    }
                }
            }
            return kimeno.Substring(0, bemeno.Length);

        }
    }
}
