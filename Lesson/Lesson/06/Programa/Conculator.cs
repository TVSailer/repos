
namespace Lesson._06
{
    internal class Conculator
    {
        private IObjekt[] _objekt = new IObjekt[] {
            new POW(),
            new Umnoshit(),
            new Delit(),
            new Minus(),
            new Plus(),
            new Fac()
        };

        public void RunComand(string operetion, double[] param)
        {
            double result = 0;

            for (int i = 0; i < _objekt.Length; i++)
            {
                if (_objekt[i].ChekZnak(operetion))
                {
                    result = _objekt[i].Run(param);
                    break;
                }
            }

            Console.WriteLine("Результат: " + result);
        }

        private IObjekt FindOperetions(string operetion)
        {
            for (int i = 0; i < _objekt.Length; i++)
            {
                if (_objekt[i].ChekZnak(operetion))
                {
                    return _objekt[i];
                }
            }
            return null;
        }

        public void ReadInfo()
        {
            string operetion;

            Console.Write("Введите операцию (* / +  - POW Fac): ");
            operetion = Console.ReadLine();

            IObjekt operetions = FindOperetions(operetion);

            if (operetions != null)
            {
                double[] param = new double[operetions.CountParam];

                for (int i = 0; i < param.Length; i++)
                {
                    Console.Write($"Введите праметр {i + 1}: ");
                    param[i] = int.Parse(Console.ReadLine());
                }

                RunComand(operetion, param);
            }
            else
            {
                Console.WriteLine($"Данная операция не существует: {operetion}");
            }
        }
    }
}
