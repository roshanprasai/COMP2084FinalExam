using System.Threading.Tasks;

[Fact]
public async Task Delete_ReturnsDeleteView_WhenIdIsValid()
{
    // Arrange
    var dbContext = // mock or use in-memory context
    var controller = new ProductsController(dbContext);
    var validId = 1; // Use valid product ID

    // Act
    var result = await controller.Delete(validId) as ViewResult;

    // Assert
    Assert.NotNull(result);
    Assert.Equal("Delete", result.ViewName ?? "Delete");
}
