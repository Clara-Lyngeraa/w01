namespace w01.Tests;

public class LeapYearTest
{
    [Fact]
    public void divisible_by_four()
    {
        //arrange
        var sut = new Program();

        //Act
        var result = sut.isLeapYear(128);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void divisible_by_hundred()
    {
        var sut = new Program();

        var result = sut.isLeapYear(4);

        result.Should().BeTrue();
    }
}