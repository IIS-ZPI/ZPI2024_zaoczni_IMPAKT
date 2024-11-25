using ConsoleApp1.Math.Interfaces;

namespace ConsoleApp1.Math.Implementations;

class MathService : IArithmeticsAdd
{
    public double Addition(double a, double b)
    {
        return a + b;
    }
}