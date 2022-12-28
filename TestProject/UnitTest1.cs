using CrawImplementations;
using CrawlingInterfaces;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ICrawling crawling = new Crawling();
            crawling.Craw("https://www.example.com");
        }
    }
}