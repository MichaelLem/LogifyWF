using Logify.BizLayer;
using Logify.Models;
using System.Configuration;

namespace Logify.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Get_TimeCard_Returns_TimeEntry()
        {
            //Assemble - Arrange
            Session session = new Session(1);
            TimeEntries timeEntry = new TimeEntries();

            //Act
            timeEntry = session.GetTimeCard(1, DateTime.Now.ToShortDateString());

            //Assert - test the stuff
            Assert.IsNotNull(timeEntry);

        }

        [Test]
        public void ValidateLogDate_WhenDateIsToday_ReturnsFormattedDateAndIsValidTrue()
        {
            // Arrange
           var session = new Session(1);
            string today = DateTime.Now.ToShortDateString();

            // Act
            string result = session.ValidateLogDate(today, out bool isValid);

            // Assert
            Assert.That(isValid, Is.True);
            Assert.That(result, Is.EqualTo(DateTime.Now.ToShortDateString()));
        }

        [Test]
        public void ValidateLogDate_WhenDateIsInPast_ReturnsFormattedDateAndIsValidTrue()
        {
            // Arrange
           var session = new Session(1);
            DateTime pastDate = DateTime.Now.AddDays(-5);
            string input = pastDate.ToShortDateString();

            // Act
            string result = session.ValidateLogDate(input, out bool isValid);

            // Assert
            Assert.That(isValid, Is.True);
            Assert.That(result, Is.EqualTo(pastDate.ToShortDateString()));
        }

        [Test]
        public void ValidateLogDate_WhenDateIsInFuture_ReturnsEmptyStringAndIsValidFalse()
        {
            // Arrange
           var session = new Session(1);
            string futureDate = DateTime.Now.AddDays(1).ToShortDateString();

            // Act
            string result = session.ValidateLogDate(futureDate, out bool isValid);

            // Assert
            Assert.That(isValid, Is.False);
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void ValidateLogDate_WhenDateIsInvalid_ReturnsEmptyStringAndIsValidFalse()
        {
            // Arrange
           var session = new Session(1);
            string invalidDate = "not-a-date";

            // Act
            string result = session.ValidateLogDate(invalidDate, out bool isValid);

            // Assert
            Assert.That(isValid, Is.False);
            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void ValidateLogDate_WhenDateIsEmpty_ReturnsEmptyStringAndIsValidFalse()
        {
            // Arrange
           var session = new Session(1);
            string emptyDate = "";

            // Act
            string result = session.ValidateLogDate(emptyDate, out bool isValid);

            // Assert
            Assert.That(isValid, Is.False);
            Assert.That(result, Is.EqualTo(""));
        }
    }
}
