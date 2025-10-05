using Tyuiu.MoskalevEA.Sprint2.Task2.V15.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine("Точка находится В заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка находится НЕ заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
