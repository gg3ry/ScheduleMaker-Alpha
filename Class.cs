using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker_Alpha
{
    internal class Osztaly
    {
        public int Évfolyam;
        public char OsztályJel;
        public int Létszám;
        public Dictionary<Tantargy, int> TantárgyakÓraszáma;
        public Tanar OsztályFönök;
        public Osztaly() { }
    }
}
