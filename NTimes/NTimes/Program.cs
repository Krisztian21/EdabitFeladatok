using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a Sztringet: ");
            string bemeno = Console.ReadLine();
            Console.Write("Kérem az ismétlés számát: ");
            int hanyszor = Convert.ToInt32(Console.ReadLine());
            Ismetel szoveg = new Ismetel(bemeno);
            Console.WriteLine($"A ismételt string: {Ismetel(bemeno, hanyszor)}");
            Console.WriteLine($"A ismételt string: {szoveg.Ismeteles(bemeno, hanyszor)}");
            Console.ReadLine();
        }
        static string Ismetel(string bemeno, int hanyszor)
        {
            string kimeno="";
            if(bemeno.Length==0)
            {
                return kimeno="Üres Stringgel nem tudok dolgozni.";
            }
            else
            {
                for(int i=0; i<bemeno.Length;i++)
                {
                    for(int j=0; j<hanyszor; j++)
                    {
                        kimeno=String.Concat(kimeno, bemeno[i]);
                    }
                }
                return kimeno;
            }
        }
    }
}