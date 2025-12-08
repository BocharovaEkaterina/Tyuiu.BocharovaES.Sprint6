using Tyuiu.BocharovaES.Sprint6.Task5.V19.Lib;
namespace Tyuiu.BocharovaES.Sprint6.Task5.V19.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
