using Logify.BizLayer;
using Logify.Models;

namespace Logify.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetTimeCardReturnsTimeEntry()
        {
            //Assemble - Arrange
            Session session = new Session(1);
            TimeEntries timeEntry = new TimeEntries();

            //Act
            timeEntry = session.GetTimeCard(1, 1, DateTime.Now.ToShortDateString());

            //Assert - test the stuff
            Assert.IsNotNull(timeEntry);

        }
    }
}