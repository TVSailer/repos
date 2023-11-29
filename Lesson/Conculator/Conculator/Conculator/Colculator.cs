
namespace Conculator
{
    internal class Colculator
    {
        private baseZnak[] znaks = new baseZnak[]
        {
            new Plus(), new Minus(), new Delit(), new Umnoshit(),
        };
        public double Run(string operions, double number1, double number2)
        {
            for (int i = 0; i < znaks.Length; i++) 
            {
                if (znaks[i].chekZnak(operions))
                {
                    return znaks[i].Run(number1, number2);
                }
            }
            return 0;
        } 
    }
}
