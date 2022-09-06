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

        var result = sut.isLeapYear(1700);

        result.Should().BeFalse();
    }

    [Fact]
    public void yay()
    {
        var sut = new Program();

        var result = sut.LeapYearOrNot(1664);

        result.Should().Be("yay");
    }

    [Fact]
    public void nay()
    {
        var sut = new Program();

        var result = sut.LeapYearOrNot(1700);

        result.Should().Be("nay");
    }
    
    [Fact]
    public void before_1582()
    {
        var sut = new Program();

        var result = sut.LeapYearOrNot(1580);

        result.Should().Be("Neeeeeeeeeej for tideligt");        
    }

    [Fact]
    public void throws_exception()
    {
        var sut = new Program();

        var result = sut.getInput("hej");

        result.Should().Be(0);        
    }


}