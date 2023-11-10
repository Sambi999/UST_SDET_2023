using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        
        public void Init()
        {
            Console.WriteLine("Setup method");
        }
        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 method");
            
            Assert.AreEqual(1, 1);
        
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 method");
            Assert.AreEqual(1, 1);
        }
        [OneTimeTearDown]
        public void Close()
        {
            Console.WriteLine("Close method");
        }
    }
}