using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
    class Pajcek1 : Pajcek
    {
        public Pajcek1(string naziv) :base(naziv)
        {
            this.naziv = naziv;
        }

        public override string GlasajSe()
        {
            return "Ojnkkkkkk Ojnkkkkkk";
        }
    }
}
