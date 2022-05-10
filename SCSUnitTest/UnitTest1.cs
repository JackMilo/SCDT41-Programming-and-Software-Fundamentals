using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using SCSDatabase;

namespace SCSUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestSignificant()
        {
            // Arrange
            Significant service;
            // Act
            service = new Significant("Cleaning", new DateTime(2022, 01, 01), Enums.SignificantServiceType.WATER_DAMAGE, Enums.IssueSeverity.LOW);

            String testDate = service.ToString();
            // Assert
            Assert.Equal("Cleaning, 01/01/2022 00:00:00, WATER_DAMAGE, LOW", testDate);
            Assert.IsType<Significant>(service);
        }

        [Fact]
        public void TestCommercial()
        {
            // Arrange
            Commercial service;
            // Act
            service = new Commercial("Cleaning", new DateTime(2022, 01, 01), Enums.CosmeticServiceType.DUSTING);

            String testDate = service.ToString();
            // Assert
            Assert.Equal("Cleaning, 01/01/2022 00:00:00, DUSTING", testDate);
            Assert.IsType<Commercial>(service);
        }

        [Fact]
        public void TestTeamMember()
        {
            // Arrange
            TeamMember service;
            // Act
            service = new TeamMember("Jack", "Milo", "Jack.Milo", "123");

            String testDate = service.ToString();
            // Assert
            Assert.Equal("Jack, Milo, Jack.Milo, 123", testDate);
            Assert.IsType<TeamMember>(service);
        }

        [Fact]
        public void TestCustomer()
        {
            // Arrange
            Customer service;
            // Act
            service = new Customer("Jack", "Milo");

            String testDate = service.ToString();
            // Assert
            Assert.Equal("Jack, Milo", testDate);
            Assert.IsType<Customer>(service);
        }
    }
}