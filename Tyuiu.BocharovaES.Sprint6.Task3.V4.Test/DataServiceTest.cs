using Tyuiu.BocharovaES.Sprint6.Task3.V4.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            
            int[,] matrix = new int[5, 5] { { -14, -7, 18, 12, -20 },
                                            { -2, -15, -19, -19, -3 },
                                            { -18, -5, -10, 14, -17 },
                                            { -1, 2, -10, 0, 11 },
                                            { 6, -18, 0, 19, 16 } };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = { { 0, -7, 0, 0, 0 },
                            { 0, -15, -19, -19, -3 },
                            { 0, -5, 0, 0, -17 },
                            { -1, 0, 0, 0, 11 },
                            { 0, 0, 0, 19, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
