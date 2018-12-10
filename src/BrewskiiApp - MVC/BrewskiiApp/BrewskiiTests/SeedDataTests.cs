/*
Problems targeting correct frameworks.

using BrewskiiApp.Models;
using Moq;
using NUnit.Framework;
using System;

namespace BrewskiiApp.Models
{
    [TestFixture]
    public class SeedDataTests
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

        private SeedData CreateSeedData()
        {
            return new SeedData();
        }

       *[Test]
        public void Initialize_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateSeedData();
            IServiceProvider serviceProvider = TODO;

            // Act
            unitUnderTest.Initialize(
                serviceProvider);

            // Assert
            Assert.Fail();
        }
    }
}
*/