using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker_Alpha
{
    public enum TeremTipus { IT, Tesi, Biológia, Fizika, Közismereti }
    internal class Tanterem
    {
        public string TeremSzám;
        public TeremTipus Tipus;
        public Tanterem() { }
        public Tanterem(string teremszám, TeremTipus tipus)
        {
            TeremSzám = teremszám;
            Tipus = tipus;
        }
    }
}
