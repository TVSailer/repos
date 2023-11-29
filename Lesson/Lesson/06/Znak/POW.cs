using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._06
{
    class POW : IObjekt
    {

        public int CountParam { get => 2; }

        public bool ChekZnak(string operetion)
        {
           return operetion == "POW";
        }

        public double Run(double[] param)
        {
            return Math.Pow(param[0], param[1]);
        }
    }
}
