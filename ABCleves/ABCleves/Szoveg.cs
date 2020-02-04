using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCleves
{
    public enum Betuk { a = 1, á, b, c, d, e, é, f, g, h, i, í, j, k, l, m,
               n, o, ó, ö, ő, p, q, r, s, t, u, ú, ü, ű, v, w, x, y, z, ß } //Magyar ABC megoldás
    class Szoveg
    {
        public string Bemeno { get; set; }
        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
        }
        public string Sorrendbe_2()//Magyar ABC megoldás
        {
            string kimeno = "ß";
            for (int i = 0; i < this.Bemeno.Length; i++)
            {
                Betuk be;
                Enum.TryParse(this.Bemeno[i].ToString(), true, out be);
                for (int j = 0; j < kimeno.Length; j++)
                {
                    Betuk ki;
                    Enum.TryParse(kimeno[j].ToString(), true, out ki);
                    if ((int)be < (int)ki)
                    {
                        kimeno = String.Concat(kimeno.Substring(0, j), this.Bemeno[i], kimeno.Substring(j));
                        break;
                    }
                }
            }
            return kimeno.Substring(0, this.Bemeno.Length);

        }
    }
}
