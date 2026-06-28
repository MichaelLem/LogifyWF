using Logify.BizLayer;
using Logify.DataLayer;
using Logify.Models;
using System.Configuration;



namespace Logify.Tests
{
    public class AuthenticateTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Authenticate_Null_UserName_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = null;
            string password = "password123";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }

        [Test]
        public void Test_Authenticate_Whitespace_UserName_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "   ";
            string password = "password123";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }
        [Test]
        public void Test_Authenticate_Empty_UserName_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "";
            string password = "password123";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }

        [Test]
        public void Test_Authenticate_Null_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "testuser";
            string password = null;

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }

        [Test]
        public void Test_Authenticate_Whitespace_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "testuser";
            string password = "   ";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }
        [Test]
        public void Test_Authenticate_Empty_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "testuser";
            string password = "";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsFalse(result.IsAuthenticated);

        }

        [Test]
        public void Test_Authenticate_Valid_UserName_And_Password_Returns_IsAuthenticated_EqualsTrue()
        {
            //Arrange
            Authenticate auth = new Authenticate();

            string userName = "mike";
            string password = "mike";

            //Act

            UserAccount result = auth.Validate(userName, password);

            //Assert

            Assert.IsTrue(result.IsAuthenticated);

        }

        [Test]
        public void Test_Authenticate_Empty_UserName_And_Empty_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            // Arrange
            Authenticate auth = new Authenticate();

            string userName = "";
            string password = "";

            // Act
            UserAccount result = auth.Validate(userName, password);

            // Assert
            Assert.IsFalse(result.IsAuthenticated);
        }

        [Test]
        public void Test_Authenticate_Valid_UserName_And_Invalid_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            // Arrange
            Authenticate auth = new Authenticate();

            string userName = "mike";
            string password = "wrongPassword";

            // Act
            UserAccount result = auth.Validate(userName, password);

            // Assert
            Assert.IsFalse(result.IsAuthenticated);
        }

        [Test]
        public void Test_Authenticate_Invalid_UserName_And_Valid_Password_Returns_IsAuthenticated_EqualsFalse()
        {
            // Arrange
            Authenticate auth = new Authenticate();

            string userName = "notARealUser";
            string password = "mike";

            // Act
            UserAccount result = auth.Validate(userName, password);

            // Assert
            Assert.IsFalse(result.IsAuthenticated);
        }
    }
}