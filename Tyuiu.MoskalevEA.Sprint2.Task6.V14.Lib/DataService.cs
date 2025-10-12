using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevEA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int day = d;
            int week = k;

            switch (d % 7)
            {
                case 1 % 7: return "понедельник";            
                case 2 % 7: return "вторник";
                case 3 % 7: return "среда";
                case 4 % 7: return "четверг";
                case 5 % 7: return "пятница";
                case 6 % 7: return "суббота";
                case 7 % 7: return "воскресенье";
                default:
                    throw new ArgumentException($"день должнен быть от 1 до 7. Значение {d}");
            }     
        }
    }
}