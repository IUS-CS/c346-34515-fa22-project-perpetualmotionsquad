using Xunit;
using Moq;
using Interfaces.GoogleService;
using Controllers;
namespace tests;

public class UnitTest2
{
    private readonly Mock<IGoogleService> googleServiceMock = new();
    private RestautantsController controller;


    [Fact]
    public void LatLngReturnFalse1()
    {
        googleServiceMock.Setup(f => f.GetRestautantsByLatLng("53", "AA"));

        // Arrange
        controller = new RestautantsController(googleServiceMock.Object);

        // Act 
        var result = controller.GetRestaurants("53", "AA");

        // Assert
        googleServiceMock.Verify(f => f.GetRestautantsByLatLng(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void LatLngReturnFalse2()
    {
        googleServiceMock.Setup(f => f.GetRestautantsByLatLng("546", "33"));

        // Arrange
        controller = new RestautantsController(googleServiceMock.Object);

        // Act 
        var result = controller.GetRestaurants("546", "33");

        // Assert
        googleServiceMock.Verify(f => f.GetRestautantsByLatLng(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }


    [Fact]
    public void LatLngReturnFalse3()
    {
        googleServiceMock.Setup(f => f.GetRestautantsByLatLng("AA", "BB"));

        // Arrange
        controller = new RestautantsController(googleServiceMock.Object);

        // Act 
        var result = controller.GetRestaurants("AA", "BB");

        // Assert
        googleServiceMock.Verify(f => f.GetRestautantsByLatLng(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }


    [Fact]
    public void LatLngReturnTrue1()
    {
        googleServiceMock.Setup(f => f.GetRestautantsByLatLng("33.3", "44.3"));

        // Arrange
        controller = new RestautantsController(googleServiceMock.Object);

        // Act 
        var result = controller.GetRestaurants("546", "");

        // Assert
        googleServiceMock.Verify(f => f.GetRestautantsByLatLng(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }

    [Fact]
    public void LatLngReturnTrue2()
    {
        googleServiceMock.Setup(f => f.GetRestautantsByLatLng("22", "33"));

        // Arrange
        controller = new RestautantsController(googleServiceMock.Object);

        // Act 
        var result = controller.GetRestaurants("546", "");

        // Assert
        googleServiceMock.Verify(f => f.GetRestautantsByLatLng(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
    }
}