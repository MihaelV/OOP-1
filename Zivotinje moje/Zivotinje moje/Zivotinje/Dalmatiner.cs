using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
        class Dalmatiner : Pas
    {
        public Dalmatiner(string n) : base(n)
        {
            naziv = n;
        }
        public override string GlasajSe()
        {
            return "Vauuuu";
        }
    }
}
