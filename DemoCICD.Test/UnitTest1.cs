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
            HelloController helloController = new HelloController();

            var result = helloController.Get();

            Assert.AreEqual("Hello World!", result);
        }

        [TestMethod]
        public void GetMethodWithId_Value_ShouldReturnHelloValue()
        {
            //setup

            string value = "Test";
            
            HelloController helloController = new HelloController();

            var result = helloController.Get(value);

            Assert.IsTrue(result.Contains(value));
        }
    }
}
