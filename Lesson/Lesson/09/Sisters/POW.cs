
namespace Lesson._09
{
    class POW : Father, IObject
    {
        public override string operetions => "POW";
        public override double Run(double[] param)
        {
            return Math.Pow(param[0], param[1]);
        }
    }
}
