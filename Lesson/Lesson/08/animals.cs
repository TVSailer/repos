
namespace Lesson._08
{
    class Animals
    {
        private IAnim[] animals = new IAnim[]
        {
            new Cat(), new Dog(), new Pig()
        };

        
        private void ChekAnim(int positions)
        {
            for (int i = 0;i < animals.Length; i++)
            {
                if (animals[i].ChekAnim(positions))
                {
                    Console.WriteLine($"Вы выбрали: {animals[i].Name}");
                    Console.Write($"{animals[i].Name} : {animals[i].Voic}");
                    break;
                }
            }
        }

        private void Price() 
        {
            Console.WriteLine("Доступные животные: ");
            for (int i = 0; i < animals.Length; i++) 
            {
                Console.WriteLine($"{i+1}. {animals[i].Name}");
            }
        }

        public void InfoComand()
        {
            Price();
            Console.WriteLine("Выедите номер животного: ");
            try
            {
                int positions = int.Parse(Console.ReadLine());
                if (positions < 4 && positions > 0)
                {
                    ChekAnim(positions);
                }
                else { Console.WriteLine("Вы ввели не верное число!"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Вы введи НЕ ТОТ символ! " + ex.Message);
            }
            
        }
        
    }
}
