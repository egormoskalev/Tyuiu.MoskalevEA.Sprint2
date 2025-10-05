using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevEA.Sprint2.Task0.V17.Lib;

public class DataService : ISprint2Task1V22
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        bool[] bools = new bool[6];
        bool[] res = bools;

        res[0] = (a < b) && (c > d);
        res[1] = (a != b) || (c != d); 
        res[2] = (b <=  a + 375) & (c <= d + 99);
        res[3] = (a > b + 1) | (d > c);
        res[4] = (a != b - 375) && (d != c - 99);
        res[5] = ! (res[0]);

        return res;
    }
}
//  a = 324, b = 696, c = 254, d = 155