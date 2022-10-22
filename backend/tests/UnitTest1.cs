using Xunit;
using Moq;
using Interfaces.FlightService;
using Controllers;
namespace tests;

public class UnitTest1
{
    private readonly Mock<IFlightService> flightServiceMock = new();
    private FlightsController controller;


    [Fact]
    public void ReturnFalse1()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("546", ""));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("546", "");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void ReturnFalse2()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("AA11", ""));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("AA11", "");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void ReturnFalse3()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("AA1111", ""));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("AA11111", "");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void ReturnTrue1()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("AA546", ""));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("AA546", "");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }

    [Fact]
    public void ReturnTrue2()
    {
        flightServiceMock.Setup(f => f.GetFlightFromFlightNumber("BB111", ""));

        // Arrange
        controller = new FlightsController(flightServiceMock.Object);

        // Act 
        var result = controller.GetFlight("BB111", "");

        // Assert
        flightServiceMock.Verify(f => f.GetFlightFromFlightNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
    }
}