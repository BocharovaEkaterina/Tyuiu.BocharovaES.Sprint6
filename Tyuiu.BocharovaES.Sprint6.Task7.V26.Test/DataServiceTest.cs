using Tyuiu.BocharovaES.Sprint6.Task7.V26.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask7V26.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask7V26.csv";
            int[,] wait = {{19, -9, 16, 16, -1, 11, 14, -8, 6, -2},
                           {-13, -1, 10, 18, 2, -16, -17, 12, -17, 20},
                           {-10, 222, 5, -1, 0, 20, -19, 2, 9, -8 },
                           {-17, 222, 11, -14, -14, -10, 8, -12, -17, 2},
                           {-18, -1, -19, 19, -1, 20, 14, 9, 17, 11},
                           {2, 222, -14, 2, 8, -4, 11, -20, -18, -20},
                           {-13, -13, -13, 18, -7, -15, 13, 2, 14, 3},
                           {4, 222, -12, -1, -7, 7, 10, 3, 19, -11},
                           {-1, 222, -9, -17, 16, -6, 1, -8, -17, 20},
                           {10, 1, 2, 1, 3, -19, 4, 12, -7, -17 } };
            CollectionAssert.AreEqual(ds.GetMatrix(path), wait);
        }
    }
}
