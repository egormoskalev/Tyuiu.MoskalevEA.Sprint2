using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevEA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int day = k;
            int week = d;
            int dayofweek = (d + k - 1) % 7 ;
            switch (dayofweek)
            {
                case 0: return "Понедельник";            
                case 1: return "Вторник";
                case 2: return "Среда";
                case 3: return "Четверг";
                case 4: return "Пятница";
                case 5: return "Суббота";
                case 6: return "Воскресенье";
                default:
                    throw new ArgumentException($"день должнен быть от 1 до 7. Значение {d}");
            }     
        }
    }
}