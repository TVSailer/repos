
namespace Conculator
{
    class Plus : baseZnak
    {
        public override string operetion => "+";

        public override double Run(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
