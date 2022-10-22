using Xunit;
using Moq;
using Interfaces.FlightService;
using Controllers;
using Services.FlightService;
using Microsoft.AspNetCore.Mvc;

namespace tests;

public class UnitTest1
{
    private readonly Mock<IFlightService> flightServiceMock = new();
    private FlightsController controller;


    [Fact]
    public void ReturnFalse()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("546", "2022-10-22"));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("546", "2022-10-22");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }


    [Fact]
    public void ReturnTrue()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("AA546", "2022-10-22"));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("AA546", "2022-10-22");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}