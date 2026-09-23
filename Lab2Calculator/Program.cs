using System;

class Calculator
{
    static void Main()
    {
        bool test = true;
        do
        {
            char op = GetOp();
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%' || op == '^' ||
                op == 's' || op == 'S' || op == 'a' || op == 'A' || op == 'f' || op == 'F' || op == 'c' || op == 'C' || op == 'r' || op == 'R')
            {
                double a = GetNum();
                double b;
                if (op == 's' || op == 'S' || op == 'a' || op == 'A' || op == 'f' || op == 'F' || op == 'c' || op == 'C' || op == 'r' || op == 'R')
                {
                    b = 0; // These operations only need one number
                }
                else
                {
                    b = GetNum2();
                }
                double result = Calculate(a, b, op);
                Output(a, b, op, result);
                do
                {
                    char rep = Again();
                    if (rep == 'y' || rep == 'Y')
                    {
                        break;
                    }
                    else if (rep == 'n' || rep == 'N')
                    {
                        test = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Try again.\n");
                        continue;
                    }
                } while (test);

            }
            else
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
                continue;
            }
        } while (test);

    }

    //GetOp(1)
    static char GetOp()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter an operator (+, -, *, /, %, ^, s [Square], a [Abs], f [Floor], c [Ceiling], r [Random]): ");
                return Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
            }

        }
    }
    //(1)

    //GetNum(2)
    static double GetNum()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                return num1;
            }
            catch
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
            }
        }
    }
    //(2)

    //GetNum2(3)
    static double GetNum2()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter a number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                return num2;
            }
            catch
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
            }
        }
    }
    //(3)

    //Calculate(4)
    static double Calculate(double num1, double num2, char op)
    {
        Random rand = new Random();
        if (op == '+')
            return num1 + num2;
        else if (op == '-')
            return num1 - num2;
        else if (op == '*')
            return num1 * num2;
        else if (op == '/')
        {
            if (num2 != 0)
                return num1 / num2;
            else
                Console.WriteLine("Cannot divide by zero.");
        }
        else if (op == '%')
        {
            if (num2 != 0)
                return num1 % num2;
            else
                Console.WriteLine("Cannot perform modulus with zero.");
        }
        else if (op == '^')
            return Math.Pow(num1, num2);
        else if (op == 's' || op == 'S')
            if (num1 >= 0)
                return Math.Sqrt(num1); // Square Root Function
            else
            {
                Console.WriteLine("Error: Cannot take the square root of a negative number.");
                return double.NaN;
            }
        else if (op == 'a' || op == 'A')
            return Math.Abs(num1);  // Absolute Value
        else if (op == 'f' || op == 'F')
            return Math.Floor(num1);  // Floor
        else if (op == 'c' || op == 'C')
            return Math.Ceiling(num1);  // Ceiling
        else if (op == 'r' || op == 'R')
            return rand.Next(0, (int)num1 + 1);  // Random number
        else
        {
            Console.WriteLine("Invalid operation.");
            return double.NaN;
        }

        return double.NaN;
    }
    //(4)

    //OutPut(5)
    static void Output(double num1, double num2, char op, double result)
    {
        if (op == 's' || op == 'S')
            Console.WriteLine($"The square root of {num1} is: {result}");
        else if (op == 'a' || op == 'A')
            Console.WriteLine($"The absolute value of {num1} is: {result}");
        else if (op == 'f' || op == 'F')
            Console.WriteLine($"When you round {num1} down you get: {result}");
        else if (op == 'c' || op == 'C')
            Console.WriteLine($"When you round {num1} up you get: {result}");
        else if (op == 'r' || op == 'R')
            Console.WriteLine($"A random number between 0 and {num1} is: {result}");
        else
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
    //(5)

    //Again(6)
    static char Again()
    {
        while (true)
        {
            try
            {
                Console.Write("Do you want to use calculator again?(y/n):");
                char rep = Convert.ToChar(Console.ReadLine());
                return rep;
            }
            catch
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
            }


        }
    }
    //(6)
}




