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
            int d = Convert.ToInt32(Console.ReadLine());

            string result;

            if ((d <= 0)||(d >= 366))
            {
                result = "Введенно неверное значение!";
            }
            else
            {
                result = "Этот день: " + ds.FindDayName(d, d);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
