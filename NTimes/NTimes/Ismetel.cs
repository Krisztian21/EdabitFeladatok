using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimes
{
    class Ismetel
    {
        public string Bemeno { get; set; }

        public Ismetel(string bemeno)
        {
            this.Bemeno = bemeno;
        }
        public string Ismeteles(string bemeno, int hanyszor)
        {
            string kimeno = "";
            if (bemeno.Length == 0)
            {
                return kimeno = "Üres Stringgel nem tudok dolgozni.";
            }
            else
            {
                for (int i = 0; i < bemeno.Length; i++)
                {
                    for (int j = 0; j < hanyszor; j++)
                    {
                        kimeno = String.Concat(kimeno, bemeno[i]);
                    }
                }
                return kimeno;
            }
        }
    }
}
