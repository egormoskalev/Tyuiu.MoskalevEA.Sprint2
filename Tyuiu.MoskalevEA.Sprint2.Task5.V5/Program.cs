using Tyuiu.MoskalevEA.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MoskalevEA.Sprint2.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер карты: ");
            int x = Convert.ToInt32(Console.ReadLine());

            string result;

            if ((6 > x) || (x > 14))
            {
                result = "Введенно неверное значение!";
            }
            else
            {
                result = "Эта карта: " + ds.FindCardValue(x);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(result);

            switch (x)
            {
                case 6:
                    Console.WriteLine($"карта {ds.FindCardValue(x)} является самой малой по достоинству");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    Console.WriteLine($"карта {ds.FindCardValue(x)} больше {ds.FindCardValue(x - 1)}, но меньше {ds.FindCardValue(x + 1)}");
                    break;
                case 14:
                    Console.WriteLine($"карта {ds.FindCardValue(x)} является самой большой по достоинству");
                    break;
            }
            Console.ReadKey();
        }
    }
}
