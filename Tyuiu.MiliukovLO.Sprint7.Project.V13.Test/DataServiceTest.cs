using Tyuiu.MiliukovLO.Sprint7.Project.V13.Lib;

namespace Tyuiu.MiliukovLO.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(10, ds.GetCountries().Count());
        }
    }
}