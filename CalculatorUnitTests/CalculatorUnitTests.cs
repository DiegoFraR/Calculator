using CalculatorEngine.CalculatorEngine;

namespace CalculatorUnitTests;

//All the assertions occur in the setup of each test method. 

public class Tests()
{
    private ICalculatorEngine _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new CalculatorEngine.CalculatorEngine.CalculatorEngine();
    }
    
    //Addition Tests
    [Test]
    [TestCase(2.5, 3, 5.5, "2.5 + 3 = ")]
    [TestCase(3, 3, 6, "3 + 3 = ")]
    [TestCase(-5, -3, -8, "-5 + -3 = ")]
    public void AddTwoNumbers_ReturnsSum(double valOne, double valTwo, double expected, string stringOperation)
    {
        //Act
        var result = _calculator.Add(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
        Assert.That(result.ResultSuccess, Is.EqualTo(true));
        Assert.That(result.StringOperation, Is.EqualTo(stringOperation));
    }

    //Subtraction Tests
    [Test]
    [TestCase(3, 2, 1)]
    [TestCase(-3, 3 , -6)]
    [TestCase(-5, -3.5, -1.5)]
    public void SubtractTwoNumbers_ReturnsSum(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Subtract(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    //Multiplication Tests
    [Test]
    [TestCase(3, 2, 6)]
    [TestCase(-3, 3 , -9)]
    [TestCase(-5, -3.5, 17.5)]
    public void MultiplyTwoNumbers_ReturnsResult(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Multiplication(valOne, valTwo);
        //Asset
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    //Division Tests
    [Test]
    [TestCase(3, 3, 1)]
    [TestCase(3.5, .5, 7)]
    [TestCase(-7, 3.5, -2)]
    [TestCase(3, 9, 0.33333333333333333)]
    public void DivideTwoNumbers_ReturnsResult(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Division(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }
    
    [Test]
    [TestCase(3, 0, "Error Occured: Cannot Divide by Zero!")]
    [TestCase(3.5, 0, "Error Occured: Cannot Divide by Zero!")]
    public void DivideTwoNumbers_ReturnsDivideByZeroError_WhenValTwoIsZero(double valOne, double valTwo, string expected)
    {
        //Act
        var result = _calculator.Division(valOne, valTwo);
        //Assert
        Assert.That(result.ResultError, Is.EqualTo(expected) );
    }

    [Test]
    [TestCase(0.333333331, 0.333333332, 1)]
    [TestCase(0.333334331, 0.333333332, 0)]
    public void TwoEqualNumbers_ReturnsTrue_WhenValuesAreTheSameUpToEightDecimalPlaces(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Equals(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(2, 3, 8)]
    [TestCase(5, 2, 25)]
    [TestCase(5, -3, 0.008)]
    public void RaiseNumber_ReturnsRaisedNumber_WhenInputsAreValid(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.RaiseToPower(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(8, 2, 3)]
    [TestCase(25, 5, 2)]
    public void LogOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Log(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(-3, 2)]
    [TestCase(0, 1)]
    public void LogOfNumber_ReturnsError_WhenValueOfAIsLessThanOrEqualToZero(double valOne, double valTwo)
    {
        //Act
        var result = _calculator.Log(valOne, valTwo);
        //Assert
        Assert.That(result.ResultError, Is.EqualTo("Error Occured: Values of A must be greater than 0!"));
    }
    
    [Test]
    [TestCase(3, 0)]
    public void LogOfNumber_ReturnsError_WhenValueOfBIsZero(double valOne, double valTwo)
    {
        //Act
        var result = _calculator.Log(valOne, valTwo);
        //Assert
        Assert.That(result.ResultError, Is.EqualTo("Error Occured: Values of B must not be 0!"));
    }

    [Test]
    [TestCase(9, 2, 3)]
    [TestCase(25, 2, 5)]
    public void RootOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double valTwo, double expected)
    {
        //Act
        var result = _calculator.Root(valOne, valTwo);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(9, 0, "Error Occured: Value of B must NOT be 0!")]
    public void RootOfNumber_ReturnsError_WhenValueOfBIsZero(double valOne, double valTwo, string error)
    {
        //Act
        var result = _calculator.Root(valOne, valTwo);
        //Assert
        Assert.That(result.ResultError, Is.EqualTo(error));
    }

    [Test]
    [TestCase(5, 120)]
    [TestCase(-5, -120)]
    [TestCase(0, 1)]
    public void FactorialOfNumber_ReturnsAnswer(double valOne, double expected)
    {
        //Act
        var result = _calculator.Factorial(valOne);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(360, 0)]
    [TestCase(-360, 0)]
    [TestCase(0, 0)]
    [TestCase(1, 0.0174524)]
    public void SineOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double expected)
    {
        //Act
        var result = _calculator.Sine(valOne);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(360, 1)]
    [TestCase(-360, 1)]
    [TestCase(1, 0.99985)]
    public void CosineOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double expected)
    {
        //Act
        var result = _calculator.Cosine(valOne);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(360, 0)]
    [TestCase(-360, 0)]
    [TestCase(1, 0.0174551)]
    public void TangentOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double expected)
    {
        //Act
        var result = _calculator.Tangent(valOne);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(8, 0.125)]
    [TestCase(-4, -0.25)]
    public void ReciprocalOfNumber_ReturnsAnswer_WhenInputsAreValid(double valOne, double expected)
    {
        //Act
        var result = _calculator.Reciprocal(valOne);
        //Assert
        Assert.That(result.Result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(0, "Error Occured: Value of A cannot be 0!")]
    public void ReciprocalOfNumber_ReturnsError_WhenInputsAreNotValid(double valOne, string expected)
    {
        //Act
        var result = _calculator.Reciprocal(valOne);
        //Assert
        Assert.That(result.ResultError, Is.EqualTo(expected));
    }
    
}