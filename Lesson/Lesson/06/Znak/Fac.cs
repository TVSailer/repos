

namespace Lesson._06
{
    class Fac : IObjekt
    {
        public int CountParam { get => 1;}

        public bool ChekZnak(string operetion)
        {
            return operetion == "Fac";
        }

        public double Run(double[] param)
        {
            double a = param[0];
            double Fac(double a)
            {
                if (a == 0) { return 1; }
                else { return a * Fac(a - 1); }
            }
            return Fac(a);
        }
    }
}
