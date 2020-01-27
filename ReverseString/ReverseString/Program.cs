using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a stringet: ");
            string visszafele = Console.ReadLine();
            Vissza megfordit = new Vissza(visszafele);
            Console.WriteLine($"A string visszafelé: {Vissza(visszafele)}");
            Console.WriteLine($"A string visszafelé: {megfordit.VisszaF()}");
            Console.ReadLine();
        }
        static string Vissza(string visszafele)
        {
            string kimeno = "";
            for(int i= visszafele.Length-1; i>=0; i--)
            {
                kimeno = String.Concat(kimeno, visszafele[i]);

            }
            return kimeno;
        }
    }
}
