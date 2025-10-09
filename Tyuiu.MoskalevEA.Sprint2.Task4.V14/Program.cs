using Tyuiu.MoskalevEA.Sprint2.Task4.V14.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x,y);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}