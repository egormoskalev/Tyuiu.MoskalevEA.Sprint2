using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MoskalevEA.Sprint2.Task0.V17.Lib;

public class DataService : ISprint2Task0V17
{
    public bool[] GetCompareOperations(int x, int y)
    {
        bool[] bools = new bool[6];
        bool[] res = bools;

        res[0] = x == y + 310;
        res[1] = x != y + 310;
        res[2] = x < y;
        res[3] = x > x + 1;
        res[4] = y <= y - 1;
        res[5] = x >= x + 1;

        return res;
    }
}
