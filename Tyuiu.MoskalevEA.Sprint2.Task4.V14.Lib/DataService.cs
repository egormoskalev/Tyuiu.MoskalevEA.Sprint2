using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevEA.Sprint2.Task4.V14.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            double res = (x * 3 < Math.Sqrt(y) + 20) 
                ? Math.Pow(2+1/Math.Pow(x, 2), y) 
                : (y * y - Math.Cos(x*x)+10) / (x * x - Math.Sin(y*y)+12);

            return Math.Round(res,3);
        }
    }
}
