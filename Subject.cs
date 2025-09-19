using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker_Alpha
{
    internal class Tantargy
    {
        public string Név;
        public List<Tanterem> Tantermek;
        public List<Tanar> Tanárok;
        public Tantargy() { }
        public Tantargy(string nev, List<Tanterem> tantermek, List<Tanar> tanarok)
        {
            Név = nev;
            Tantermek = tantermek;
            Tanárok = tanarok;
        }
    }
}
