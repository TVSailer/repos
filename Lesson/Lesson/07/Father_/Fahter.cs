
namespace Lesson._07
{
    abstract class Fahter : IObject
    {
        public abstract string operetions { get; }
        public virtual int CounParam { get => 2; }
        public abstract double Run(double[] param);
        public bool ChekZnak(string operetion)
        {
            return operetion == operetions;
        }
    }

}
