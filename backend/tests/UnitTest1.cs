using Xunit;
using Moq;
using Interfaces.FlightService;
using Controllers;
using Services.FlightService;

namespace tests;

public class UnitTest1
{
    private readonly Mock<IFlightService> flightServiceMock = new();
    private FlightsController controller;

    [Fact]
    public void ShouldReturnFalse()
    {

        var result = new FlightService().flightNumberIsValid("546"); 
        Assert.False(result);
    }
    
    [Fact]
    public void ShouldReturnTrue()
    {

        var result = new FlightService().flightNumberIsValid("AA546"); 
        Assert.True(result);
    }
}