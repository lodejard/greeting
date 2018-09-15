using Example.Hello;
using Example.World;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.Tests
{
    [TestClass]
    public class GreetingTests
    {
        [TestMethod]
        public void GreetingReturnsHelloWorld()
        {
            IGreeting greeting = new Greeting();

            var message = greeting.CreateGreeting("World");

            Assert.AreEqual("Hello, World!", message);
        }
    }
}
