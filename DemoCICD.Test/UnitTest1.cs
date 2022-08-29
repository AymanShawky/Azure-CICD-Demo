using DemoCICD.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoCICD.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetMethod_ShouldReturnHelloWorld()
        {
            //arrange
            string expected = "Hello World!";

            HelloController helloController = new HelloController();

            var result = helloController.Get();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMethodWithId_Value_ShouldReturnHelloValue()
        {
            //arrange

            string value = "Test";
            
            HelloController helloController = new HelloController();

            var result = helloController.Get(value);

            Assert.IsTrue(result.Contains(value));
        }
    }
}
