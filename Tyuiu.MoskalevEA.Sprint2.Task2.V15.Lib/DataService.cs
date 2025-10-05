using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.MoskalevEA.Sprint2.Task2.V15.Lib
{
    public class DataService : ISprint2Task2V15
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            {
                bool res;

                if (x >= 3 && x <= 5 && y == 3)
                {
                    res = true;
                }
                else if (x >= 3 && x <= 9 && y >= 4 && y <= 6) 
                {
                    res = true;
                }
                else if (x >= 8 && x <= 9 && y >= 4 && y <= 7) 
                {
                    res = true;
                }
                else if (x >= 4 && x <= 7 && y == 7)
                {
                    res = true;
                }
                else if (x == 2 && y >= 5 && y <= 7)
                {
                    res = true;
                }
                else if (x == 2 && y >= 3 && y <= 4)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

                return res; 
            }
        }
    }
}