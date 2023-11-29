
namespace Lesson._09
{
    class FAC : Father, IObject
    {
        public override string operetions => "FAC";
        public override int CounParam => 1;
        public override double Run(double[] param)
        {
            double fac = param[0];

            double _fac(double fac)
            {
                if (fac == 0) { return 1; }
                else { return fac * _fac(fac - 1); }
            }
            return _fac(fac);
        }
    }
}
