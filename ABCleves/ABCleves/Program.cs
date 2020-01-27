using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCleves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a szót: ");
            string bemeno = Console.ReadLine();
            Console.WriteLine($"A szót ábécé sorrendben: {Sorrendbe_1(bemeno)}");
            Console.WriteLine($"A szót ábécé sorrendben: {Sorrendbe_2(bemeno)}");
            Console.ReadLine();
        }
        static string Sorrendbe_1(string bemeno)
        {
            char[] tomb = bemeno.ToCharArray();
            Array.Sort(tomb);

            return new string(tomb);

        }
        static string Sorrendbe_2(string bemeno)
        {
            string kimeno = "{";
            for(int i=0; i<bemeno.Length; i++)
            {
                for(int j=0; j<kimeno.Length; j++)
                {
                    if(bemeno[i]<kimeno[j])
                    {
                        kimeno = String.Concat(kimeno.Substring(0, j), bemeno[i], kimeno[j]);
                        break;
                    }
                    kimeno = String.Concat(kimeno, bemeno[i]);
                }
            }
            return kimeno.Substring(0,bemeno.Length);

        }
    }
}
