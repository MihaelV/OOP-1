using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zivotinje_moje.Zivotinje
{
    public class zivotinje
    {
        protected string naziv;

        public zivotinje(string naziv)
        {
            this.naziv = naziv;
        }
        public zivotinje()
        {
            naziv = "nedefinirani";
        }

        public void ZadajNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public string VratiNaziv()
        {
            return naziv;
        }

        public virtual string GlasajSe()
        {
            return "Ne znam se glasati!";
        }
    }
}
