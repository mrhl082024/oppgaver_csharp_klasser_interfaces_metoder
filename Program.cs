using System.Numerics;

namespace oppgaver_csharp_klasser_interfaces_metoder;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine("insert number one");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("choose function");
        char Operators = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("insert number two");
        double num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("total");
        if (Operators == '+')
        {
            Console.WriteLine(calculator.Add(num1, num2));
        }
        if (Operators == '-')
        {
            Console.WriteLine(calculator.Subtract(num1, num2));
        }
        if (Operators == '*')
        {
            Console.WriteLine(calculator.Multiply(num1, num2));
        }
        if (Operators == '/')
        {
            Console.WriteLine(calculator.Divide(num1, num2));
        }
    }

}
