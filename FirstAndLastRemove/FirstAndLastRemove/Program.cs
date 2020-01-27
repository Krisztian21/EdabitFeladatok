using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLastRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a Sztringet: ");
            string bemeno = Console.ReadLine();
            Szoveg szoveg = new Szoveg(bemeno);
            Console.WriteLine($"A csonkolt string: {Remove_1(bemeno)}");
            Console.WriteLine($"A csonkolt string: {Remove_2(bemeno)}");
            Console.WriteLine($"A csonkolt string: {szoveg.Remove_1()}");
            Console.WriteLine($"A csonkolt string: {szoveg.Remove_2()}");
            Console.ReadLine();
        }
        static string Remove_1(string bemeno)
        {
            if(bemeno.Length<=2)
            {
                return bemeno;
            }
            else
            {
                return bemeno.Remove(bemeno.Length - 1, 1).Remove(0, 1);
            }
        }
        static string Remove_2(string bemeno)
        {
            if (bemeno.Length <= 2)
            {
                return bemeno;
            }
            else
            {
                return bemeno.Substring(1, bemeno.Length - 2);
            }
        }
    }
}