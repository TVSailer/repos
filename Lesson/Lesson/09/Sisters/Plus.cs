
namespace Lesson._09
{
    class Plus : Father, IObject
    {
        public override string operetions => "+";
        public override double Run(double[] param)
        {
            return param[0] + param[1];
        }
    }
}
