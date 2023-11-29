
namespace Conculator
{
    abstract class baseZnak
    {
        public abstract string operetion { get; }
        public bool chekZnak(string myOperetion)
        {
            return myOperetion == operetion;
        }
        public abstract double Run(double number1, double number2);
    }
}
