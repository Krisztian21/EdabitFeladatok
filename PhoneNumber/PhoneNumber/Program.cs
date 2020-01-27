using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i]=rnd.Next(10);
            }
            TelefonSzam tel = new TelefonSzam(tomb);
            Console.WriteLine($"Az ön telefon száma: {TelefonSzam(tomb)}");
            Console.WriteLine($"Az ön telefon száma: {tel.TelefonSzamSzamito()}");
            Console.ReadLine();
        }
        static string TelefonSzam(int[] tomb)
        {
            string kimeno = "";
            for(int i=0; i<tomb.Length; i++)
            {
                kimeno = String.Concat(kimeno, tomb[i]);
            }
            kimeno = String.Concat("(", kimeno.Substring(0, 3), ") ", kimeno.Substring(3, 3), "-", kimeno.Substring(6));
            return kimeno;
        }
    }
}
