using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
    public class Krava : zivotinje
    {
        public Krava(string naziv) 
        {
            this.naziv = naziv;
        }

        public override string GlasajSe()
        {
            return "Muuuu";
        }
    }
}
