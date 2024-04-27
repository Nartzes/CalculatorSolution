
using CalculatorProject;
using Microsoft.VisualStudio.TestPlatform.TestHost;
namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {
        public TestContext? TestContext { get; set; }
        [TestMethod]
        public void CalculatorProjectAdd_2_4_returns_6()
        {
            int x = 2;
            int y = 4;
            //x = int.Parse(TestContext?.Properties?["ValueX"]?.ToString());
            //y = int.Parse(TestContext?.Properties?["ValueY"]?.ToString());
            Calculator c = new Calculator();
            int result = c.Add(x, y);
            Assert.AreEqual(6, result); 
        }
    }
}