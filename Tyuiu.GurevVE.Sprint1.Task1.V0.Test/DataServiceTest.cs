using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GurevVE.Sprint1.Task1.V19.Lib
{
    [TestClass]
    public class DataService : ISprint1Task1V13
    { 
        [TestMethod]
        public double Calculate(double x)
        {
            DataService ds = new DataService();
            x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(0,5, res);


            return 0;
        }
    }
}