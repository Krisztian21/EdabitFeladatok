using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Vissza
    {
        public string VisszaFele { get; set; }
        public Vissza(string visszafele)
        {
            this.VisszaFele = visszafele;
        }
        public string VisszaF()
        {
            string kimeno = "";
            for (int i = this.VisszaFele.Length - 1; i >= 0; i--)
            {
                kimeno = String.Concat(kimeno, this.VisszaFele[i]);

            }
            return kimeno;
        }
    }
}
