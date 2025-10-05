using Tyuiu.MoskalevEA.Sprint2.Task0.V17.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 324;
            int b = 696;
            int c = 254;
            int d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
