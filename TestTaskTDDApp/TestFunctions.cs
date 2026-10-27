using TaskTDDApp;

namespace TestTaskTDDApp
{
    [TestClass]
    public sealed class TestFunctions
    {
        // Pruebas a implementar.
        [TestMethod]

        [DataRow(-8, -1L)]
        [DataRow(0, 1L)]
        [DataRow(8, 40320L)]

        public void CalculateFactorial_SeveralTests (int n, long expected)
        {
            long result = Functions.CalculateFactorial(n);
            Assert.AreEqual(expected, result);
        }
    }
}
