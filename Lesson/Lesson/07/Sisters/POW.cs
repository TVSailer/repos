
namespace Lesson._07
{
    class POW : Fahter
    {
        public override string operetions => "POW";
        public override double Run(double[] param)
        {
            return Math.Pow(param[0], param[1]);
        }
    }
}
