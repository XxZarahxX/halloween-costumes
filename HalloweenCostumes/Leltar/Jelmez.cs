using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costumes

{
    internal class Jelmez
    {
        public int sorszam;
        public string elnevezes;
        public string meret;
        public int napi_ar;
        public bool kolcsonozve;

        public Jelmez(int sorszam, string elnevezes, string meret, int napi_ar, bool kolcsonozve)
        {
            this.sorszam = sorszam;
            this.elnevezes = elnevezes;
            this.meret = meret;
            this.napi_ar = napi_ar;
            this.kolcsonozve = kolcsonozve;
        }
    }
}
