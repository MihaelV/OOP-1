using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
    class Pajcek :zivotinje
    {
        public Pajcek(string naziv)
        {
            this.naziv = naziv;
        }

        public override string GlasajSe()
        {
            return "Ojnk Ojnk";
        }

    }
}
