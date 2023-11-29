
namespace Lesson._09
{
    abstract class Father : IObject
    {
        public abstract string operetions { get; }
        public virtual int CounParam => 2;
        public bool ChekZnak(string operetion)
        {
            return operetion == operetions;
        }
        public abstract double Run(double[] param);
        
    }
}
