using Tyuiu.GurevVE.Sprint1.Task0.V13.Lib;
namespace Tyuiu.GurevVE.Sprint1.Task0.V13.Test;


[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(1, res);
    }
}   