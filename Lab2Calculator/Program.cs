using System;

class Calculator
{
    static void Main()
    {
        bool test = true;
        do
        {
            char op = GetOp();// get operator from user
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%' || op == '^' ||
                op == 's' || op == 'S' || op == 'a' || op == 'A' || op == 'f' || op == 'F' || op == 'c' || op == 'C' || op == 'r' || op == 'R')
            {
                double a = GetNum(); // get first number from user
                double b;
                if (op == 's' || op == 'S' || op == 'a' || op == 'A' || op == 'f' || op == 'F' || op == 'c' || op == 'C' || op == 'r' || op == 'R')
                {
                    b = 0; // These operations only need one number
                }
                else
                {
                    b = GetNum2();//Get second number from user
                }
                double result = Calculate(a, b, op); //Calculate the result based on the operator and numbers
                Output(a, b, op, result); //Output the result to the user
                do
                {
                    char rep = Again(); //Ask user if they want to use the calculator again
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
            else //If the operator is invalid, ask the user to try again
            {
                Console.WriteLine("\nInvalid input. Try again.\n");
                continue;
            }
        } while (test); //Keep running the calculator until the user decides to exit

    }

    //GetOp
    static char GetOp() //Get operator from user
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
   

    //GetNum
    static double GetNum() //Get first number from user
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
    

    //GetNum2
    static double GetNum2() //Get second number from user
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


    //Calculate
    static double Calculate(double num1, double num2, char op) //Calculate the result based on the operator and numbers
    {
        Random rand = new Random(); // Random number generator for 'r' operation
        if (op == '+')              // Addition
            return num1 + num2;
        else if (op == '-')         // Subtraction
            return num1 - num2;
        else if (op == '*')         // Multiplication
            return num1 * num2;
        else if (op == '/')         // Division
        {
            if (num2 != 0)              // Check for division by zero
                return num1 / num2;
            else
                Console.WriteLine("Cannot divide by zero.");
        }
        else if (op == '%')         // Modulus
        {
            if (num2 != 0)              // Check for modulus by zero
                return num1 % num2;
            else
                Console.WriteLine("Cannot perform modulus with zero.");
        }
        else if (op == '^')         // Exponentiation
            return Math.Pow(num1, num2);
        else if (op == 's' || op == 'S')    // Square Root
            if (num1 >= 0)      
                return Math.Sqrt(num1); 
            else
            {                           
                Console.WriteLine("Error: Cannot take the square root of a negative number.");
                return double.NaN;
            }
        else if (op == 'a' || op == 'A')    // Absolute Value
            return Math.Abs(num1);  
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

        return double.NaN;      // Default return value in case of an error
    }
    

    //OutPut
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


    //Again 
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
}




