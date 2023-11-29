
namespace Lesson._07
{
    class Conculator
    {
        private Fahter[] ob = new Fahter[]
        {
            new Minus(),
            new Plus(),
            new Delit(),
            new Umnoshit(),
            new POW(),
            new FAC(),
        };


        private void RunComand(string operetion, double[] param)
        {
            double result = 0;

            for (int i = 0; i < ob.Length; i++)
            {
                if (ob[i].ChekZnak(operetion))
                {
                    result = ob[i].Run(param);
                    break;
                }
            }

            Console.WriteLine("Результат: " + result);
        }

        private Fahter? ChekOb(string operetion)
        {

            for (int i = 0; i < ob.Length; i++)
            {
                if (ob[i].ChekZnak(operetion))
                {
                    return ob[i];
                }
            }
            return null;
        }

        public void RunCon()
        {
            Console.Write("Введите операцию (+ - * / POW FAC): ");
            string operetion = Console.ReadLine();

            Fahter objec = ChekOb(operetion);


            if (objec != null)
            {
                double[] param = new double[objec.CounParam];

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
