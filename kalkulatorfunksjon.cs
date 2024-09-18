public interface ICalculator
{
    /// <summary>
    /// addition method, that adds two numbers together
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns></returns>
    double Add(double a, double b);

    /// <summary>
    /// subtract method, that subtracts two numbers
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns></returns>
    double Subtract(double a, double b);

    /// <summary>
    /// Multiplying method, multiplies two numbers
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns></returns>
    double Multiply(double a, double b);

    /// <summary>
    /// Dividing method, divides two numbers
    /// </summary>
    /// <param name="a">value of a</param>
    /// <param name="b">value of b</param>
    /// <returns></returns>
    double Divide(double a, double b);
}