using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BocharovaES.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for(int x =startValue; x <= stopValue; x++)
            {
                if (x==-2)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Cos(x) + ((Math.Cos(x)) / (x + 2)) - 3 * x;
                    y = Math.Round(y, 2);
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
