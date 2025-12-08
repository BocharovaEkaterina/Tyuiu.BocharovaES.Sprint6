using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BocharovaES.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];


            int index = 0;
            double[] result;
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;


                }
                
            }
            numsArray = numsArray.Where(val => val == Math.Truncate(val)).ToArray();
            return numsArray;
        }
    }
}
