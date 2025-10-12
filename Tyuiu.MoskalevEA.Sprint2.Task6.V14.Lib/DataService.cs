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
                case 1 % 7: return "Понедельник";            
                case 2 % 7: return "Вторник";
                case 3 % 7: return "Среда";
                case 4 % 7: return "Четверг";
                case 5 % 7: return "Пятница";
                case 6 % 7: return "Суббота";
                case 7 % 7: return "Воскресенье";
                default:
                    throw new ArgumentException($"день должнен быть от 1 до 7. Значение {d}");
            }     
        }
    }
}