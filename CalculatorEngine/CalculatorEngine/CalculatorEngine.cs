namespace CalculatorEngine.CalculatorEngine;

public class CalculatorEngine : ICalculatorEngine
{
    public Answer Add(double valOne, double valTwo)
    {
        try
        {
            Answer answer = new Answer
            {
                Result = valOne + valTwo,
                StringOperation = valOne + " + " + valTwo + " = ",
                ResultSuccess = true,
            };

            return answer;
        }
        catch (Exception ex)
        {
            Answer answer = new Answer
            {
                ResultSuccess = false,
                ResultError = "Error Occured: " + ex.Message
            };
            return answer;
        }
    }

    public Answer Subtract(double valOne, double valTwo)
    {
        try
        {
            Answer answer = new Answer
            {
                Result = valOne - valTwo,
                StringOperation = valOne + " - " + valTwo + " = ",
                ResultSuccess = true,
                
            };
            return answer;
        }
        catch (Exception ex)
        {
            Answer answer = new Answer
            {
                ResultSuccess = false,
                ResultError = "Error Occured: " + ex.Message
            };
            return answer;
        }
    }

    public Answer Multiplication(double valOne, double valTwo)
    {
        try
        {
            Answer answer = new Answer
            {
                Result = valOne * valTwo,
                StringOperation = valOne + " * " + valTwo + " = ",
                ResultSuccess = true,

            };
            return answer;
        }
        catch (Exception ex)
        {
            Answer answer = new Answer
            {
                ResultSuccess = false,
                ResultError = "Error Occured: " + ex.Message
            };
            return answer;
        }
    }

    public Answer Division(double valOne, double valTwo)
    {
        Answer answer;
        if (valTwo == 0)
        {
            answer = new Answer()
            {
                ResultError = "Error Occured: Cannot Divide by Zero!",
                ResultSuccess = false
            };
            return answer;
        }
        answer = new Answer()
        {
            Result = valOne / valTwo,
            StringOperation = valOne + " / " + valTwo + " = ",
            ResultSuccess = true
        };
        return answer;
    }

    public Answer Equals(double valOne, double valTwo)
    {
        Answer answer;
        if (Decimal.Round((decimal)valOne, 8) == Decimal.Round((decimal)valTwo, 8))
        {
            answer = new Answer()
            {
                Result = 1,
                StringOperation = valOne + " == " + valTwo,
                ResultSuccess = true
            };
            return answer;
        }
        answer = new Answer()
        {
            Result = 0,
            StringOperation = valOne + " == " + valTwo,
            ResultSuccess = true
        };
        return answer;
    }
    
    public Answer RaiseToPower(double valOne, double valTwo)
    {
        Answer answer = new Answer()
        {
            Result = Math.Pow(valOne, valTwo),
            ResultSuccess = true,
            StringOperation = valOne + " ^ " + valTwo + " = "
        };
        return answer;
    }

    public Answer Log(double valOne, double valTwo)
    {
        Answer answer;
        if (valOne <= 0)
        {
            answer = new Answer()
            {
                ResultSuccess = false,
                ResultError = "Error Occured: Values of A must be greater than 0!"
            };
            return answer;
        }
        if (valTwo == 0)
        {
            answer = new Answer()
            {
                ResultSuccess = false,
                ResultError = "Error Occured: Values of B must not be 0!"
            };
            return answer;
        }
        answer = new Answer()
        {
            Result = Math.Log(valOne, valTwo),
            ResultSuccess = true,
            StringOperation = valOne + " log " + valTwo + " = "
        };
        return answer;
    }

    public Answer Root(double valOne, double valTwo)
    {
        Answer answer;
        if (valTwo == 0)
        {
            answer = new Answer()
            {
                ResultSuccess = false,
                ResultError = "Error Occured: Value of B must NOT be 0!"
            };
            return answer;
        }

        answer = new Answer()
        {
            Result = Math.Pow(valOne, 1 / valTwo),
            StringOperation = valOne + " Root " + valTwo + " = ",
            ResultSuccess = true,
        };
        return answer;
    }

    public Answer Factorial(double valOne)
    {
        Answer answer;
        if (valOne < 0 && (valOne % 2) != 0)
        {
            answer = new Answer()
            {
                Result = -1 * FactorialCalculation(Math.Abs(valOne)),
                ResultSuccess = true,
                StringOperation = valOne + "! = "
            };
            return answer;
        }
        answer = new Answer()
        {
            Result = FactorialCalculation(Math.Abs(valOne)),
            ResultSuccess = true,
            StringOperation = valOne + "! = "
        };
        return answer;
    }

    public Answer Sine(double valOne)
    {
        valOne = ConvertToRadians(valOne);
        Answer answer = new Answer()
        {
            Result = Math.Round(Math.Sin(valOne), 7),
            StringOperation = "Sin " + valOne + " = ",
            ResultSuccess = true
        };
        return answer;
    }

    public Answer Cosine(double valOne)
    {
        valOne = ConvertToRadians(valOne);
        Answer answer = new Answer()
        {
            Result = Math.Round(Math.Cos(valOne), 5),
            ResultSuccess = true,
            StringOperation = "Cos " + valOne + " = "
        };
        return answer;
    }

    public Answer Tangent(double valOne)
    {
        valOne = ConvertToRadians(valOne);
        Answer answer = new Answer()
        {
            Result = Math.Round(Math.Tan(valOne), 7),
            ResultSuccess = true,
            StringOperation = "Tan " + valOne + " = "
        };
        return answer;
    }

    public Answer Reciprocal(double valOne)
    {
        Answer answer;
        if (valOne == 0)
        {
            answer = new Answer()
            {
                ResultError = "Error Occured: Value of A cannot be 0!",
                ResultSuccess = false
            };
            return answer;
        }

        answer = new Answer()
        {
            Result = 1 / valOne,
            ResultSuccess = true,
            StringOperation = "1/" + valOne + " = "
        };
        return answer;
    }



    //Helper method for Factorial Calculation
    private static double FactorialCalculation(double valOne)
    {
        if (valOne == 1 || valOne == 0)
        {
            return 1;
        }

        return valOne * FactorialCalculation(valOne-1);
    }
    
    //Helper Method for Sin, Cos, & Tangent
    private static double ConvertToRadians(double degrees)
    {
        return Math.PI * degrees / 180;
    }
    
}