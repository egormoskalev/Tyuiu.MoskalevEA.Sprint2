using Tyuiu.MoskalevEA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер дня: ");
            int k = Convert.ToInt32(Console.ReadLine());

            
            int d = 6;

            string result;

            if ((k <= 0)||(k >= 366))
            {
                result = "Введенно неверное значение!";
            }
            else
            {
                result = "Этот день: " + ds.FindDayName(k+d, d);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
