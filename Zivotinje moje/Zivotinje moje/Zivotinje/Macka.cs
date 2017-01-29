using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
    public class Macka : zivotinje
    {
        public Macka(string naziv) 
        {
            this.naziv = naziv;
        }
        public override string GlasajSe()
        {
            return "Mijau";
        }
    }
}
