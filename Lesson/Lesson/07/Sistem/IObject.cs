
namespace Lesson._07
{
    interface IObject
    {
        string operetions { get; }
        int CounParam { get; }
        double Run(double[] param);
        bool ChekZnak(string operetion);
    }
}
