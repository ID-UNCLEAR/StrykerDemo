namespace Library.UnitTests;

public class PersonTests
{
    [Fact]
    public void IsAllowedToBuyAlcohol_ForOnAge_ReturnsTrue()
    {
        // Arrange
        var sut = new Person
        {
            Age = 18,
        };

        // Act
        var result = sut.IsAllowedToBuyAlcohol();

        // Assert
        result.Should().BeTrue();
    }


    [Fact]
    public void IsAllowedToBuyAlcohol_ForUnderAge_ReturnsFalse()
    {
        // Arrange
        var sut = new Person
        {
            Age = 17,
        };

        // Act
        var result = sut.IsAllowedToBuyAlcohol();

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void IsAllowedToBuyAlcohol_ForNegativeAge_ReturnsFalse()
    {
        // Arrange
        var sut = new Person
        {
            Age = -30,
        };

        // Act
        var result = sut.IsAllowedToBuyAlcohol();

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void IsAllowedToBuyAlcohol_ForOverAge_ReturnsTrue()
    {
        // Arrange
        var sut = new Person
        {
            Age = 19,
        };

        // Act
        var result = sut.IsAllowedToBuyAlcohol();

        // Assert
        result.Should().BeTrue();
    }
}
