namespace DiscountCalculatorModule.UnitTests;

public class DiscountCalculatorTests
{
    // Method_Scenario_ExpectedBehavior

    // Method_WhenScenario_ShouldExpectedBehavior

    // Method_ShouldExpectedBehavior_WhenScenario

    // SUT = System Under Test

    const string InvalidDiscountCode = "a";


    DiscountCalculator sut;

    public DiscountCalculatorTests()
    {
        sut = new DiscountCalculator();
    }

    [Fact]
    public void CalculateDiscount_WhenDiscountCodeIsEmpty_ShouldReturnPrice()
    {
        // Act
        var result = sut.CalculateDiscount(1, string.Empty);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void CalculateDiscount_WhenHasDiscountCodeSAVE10NOW_ShouldReturnDiscountedPriceBy10Percentage()
    {
        // Act
        var result = sut.CalculateDiscount(100, "SAVE10NOW");

        // Assert
        Assert.Equal(90, result);
    }

    [Fact]
    public void CalculateDiscount_WhenHasDiscountCodeDISCOUNT20OFF_ShouldReturnDiscountedPriceBy20Percentage()
    {
        // Act
        var result = sut.CalculateDiscount(100, "DISCOUNT20OFF");

        // Assert
        Assert.Equal(80, result);
    }

    [Fact]
    public void CalculateDiscount_WhenPriceIsNegative_ShouldThrowArgumentException()
    {
        // Act
        Action act = () => sut.CalculateDiscount(-1, string.Empty);

        // Assert
        var exception = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Negatives not allowed", exception.Message);

    }

    [Fact]
    public void CalculateDiscount_WhenHasInvalidDiscountCode_ShouldThrowArgumentException()
    {
        // Act
        Action act = () => sut.CalculateDiscount(1, InvalidDiscountCode);

        // Assert
        var exception = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Invalid discount code", exception.Message);
    }
}