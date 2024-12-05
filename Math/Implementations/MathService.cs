using IMPAKT.Math.Interfaces;

namespace IMPAKT.Math.Implementations;

class MathService : IMathService
{
    public double Addition(double a, double b)
    {
        return a + b;
    }

    public double Difference(double a, double b)
    {
        return a - b;
    }

    public double Multiplication(double a, double b)
    {
        return a * b;
    }

    public double Division(double a, double b)
    {
        return a / b;
    }
}