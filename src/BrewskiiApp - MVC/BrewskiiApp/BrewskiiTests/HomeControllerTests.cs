/*
Problems targeting correct frameworks.

using BrewskiiApp.Controllers;
using Moq;
using NUnit.Framework;

namespace BrewskiiApp.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        [TearDown]
        public void TearDown()
        {
            this.mockRepository.VerifyAll();
        }

        private HomeController CreateHomeController()
        {
            return new HomeController();
        }

        [Test]
        public void Index_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateHomeController();

            // Act
            var result = unitUnderTest.Index();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void About_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateHomeController();

            // Act
            var result = unitUnderTest.About();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Contact_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateHomeController();

            // Act
            var result = unitUnderTest.Contact();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Privacy_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateHomeController();

            // Act
            var result = unitUnderTest.Privacy();

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Error_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateHomeController();

            // Act
            var result = unitUnderTest.Error();

            // Assert
            Assert.Fail();
        }
    }
}
*/