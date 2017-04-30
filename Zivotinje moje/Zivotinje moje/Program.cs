using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zivotinje_moje.Zivotinje;

namespace Zivotinje_moje
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<zivotinje> zoo = new List<zivotinje>();
            zoo.Add(new Macka("Garfield"));
            zoo.Add(new Pas("boby"));
            zoo.Add(new Krava("milka"));
            zoo.Add(new Dalmatiner("Rex"));
            zoo.Add(new Pajcek("Đoni"));
            zoo.Add(new Pajcek1("Đoni1"));
            zoo.Add(new NeGlasamSe("Ja se ne glasam : "));
            zoo.Add(new Macka("Miro"));
            


            foreach (zivotinje z in zoo)
                Console.WriteLine("{0}: {1}",z.VratiNaziv(), z.GlasajSe());



            
                
            
            
               
        }
    }
}
