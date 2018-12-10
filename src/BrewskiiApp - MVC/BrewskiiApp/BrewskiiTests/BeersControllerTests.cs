/*
Problems targeting correct frameworks.

using BrewskiiApp.Controllers;
using BrewskiiApp.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace BrewskiiApp.Controllers
{
    [TestFixture]
    public class BeersControllerTests
    {
        private MockRepository mockRepository;

        private Mock<BrewskiiAppContext> mockBrewskiiAppContext;

        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockBrewskiiAppContext = this.mockRepository.Create<BrewskiiAppContext>();
        }

        [TearDown]
        public void TearDown()
        {
            this.mockRepository.VerifyAll();
        }

        private BeersController CreateBeersController()
        {
            return new BeersController(
                this.mockBrewskiiAppContext.Object);
        }

        [Test]
        public async Task Index_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            string beerTypeQuery = TODO;
            string searchString = TODO;

            // Act
            var result = await unitUnderTest.Index(
                beerTypeQuery,
                searchString);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Index_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            string searchString = TODO;
            bool notUsed = TODO;

            // Act
            var result = unitUnderTest.Index(
                searchString,
                notUsed);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task Details_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            int? id = TODO;

            // Act
            var result = await unitUnderTest.Details(
                id);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Create_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();

            // Act
            var result = unitUnderTest.Create();

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task Create_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            Beer beer = TODO;

            // Act
            var result = await unitUnderTest.Create(
                beer);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task Edit_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            int? id = TODO;

            // Act
            var result = await unitUnderTest.Edit(
                id);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task Edit_StateUnderTest_ExpectedBehavior1()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            int id = TODO;
            Beer beer = TODO;

            // Act
            var result = await unitUnderTest.Edit(
                id,
                beer);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task Delete_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            int? id = TODO;

            // Act
            var result = await unitUnderTest.Delete(
                id);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task DeleteConfirmed_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateBeersController();
            int id = TODO;

            // Act
            var result = await unitUnderTest.DeleteConfirmed(
                id);

            // Assert
            Assert.Fail();
        }
    }
}
*/