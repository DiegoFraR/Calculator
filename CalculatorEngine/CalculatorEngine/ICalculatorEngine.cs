namespace CalculatorEngine.CalculatorEngine;

public interface ICalculatorEngine
{
    public Answer Add(double valOne, double valTwo);
    public Answer Subtract(double valOne, double valTwo);
    public Answer Multiplication(double valOne, double valTwo);
    public Answer Division(double valOne, double valTwo);
    public Answer Equals(double valOne, double valTwo);
    public Answer RaiseToPower(double valOne, double valTwo);
    public Answer Log(double valOne, double valTwo);
    public Answer Root(double valOne, double valTwo);
    public Answer Factorial(double valOne);
    public Answer Sine(double valOne);
    public Answer Cosine(double valOne);
    public Answer Tangent(double valOne);
    public Answer Reciprocal(double valOne);
}