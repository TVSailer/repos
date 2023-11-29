
namespace Lesson._09
{
    class Conculator
    {
        private IObject[] ob = new IObject[]
        {
            new Minus(),
            new Plus(),
            new Delit(),
            new Umnoshit(),
            new POW(),
            new FAC(),
        };

        private IObject? ChekOb(string operetion)
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

            Console.Write("Введите операцию (* - + / POW FAC): ");
            string operetions = Console.ReadLine();
            IObject? poiskObjeck = ChekOb(operetions);
            if (poiskObjeck != null) 
            {
                double[] param = new double[poiskObjeck.CounParam];
                
                for (int i = 0; i < param.Length; i++)
                {

                    Console.Write($"Введите {i + 1} значение: ");
                    try
                    {
                        param[i] = int.Parse(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Вы ввели не тот символ!"); break; }
                    
                }
                
                double rezult = poiskObjeck.Run(param);
                Console.WriteLine($"Результат: {rezult}");
            }
            else { Console.WriteLine("Нет такой операции!"); }
           
        }


    }
}
