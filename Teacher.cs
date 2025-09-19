using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker_Alpha
{
    public enum Nap { Hétfő, Kedd, Szerda, Csütörtök, Péntek }
    internal class Tanar
    {
        public string Név;
        public List<Nap> BentTöltöttNapok;
        public Tanar() { }
        public Tanar(string nev, List<Nap> napokbent)
        {
            Név = nev;
            BentTöltöttNapok = napokbent;
        }
    }
}
