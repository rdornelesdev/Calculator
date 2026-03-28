
namespace CalProject;

class Calc
{
    // Main function
    public double CalcFunc()
    {

        double result = 0;

        Console.WriteLine("---------- CALCULADORA ----------");

        // Do while for validations
        double n1 = 0;
        do
        {
            Console.Write("Write first number: ");
            try
            {
                n1 = ValidateAndParse(Console.ReadLine()!, "Invalid! Please, write a correct number.");
                break;

            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        } while(true);

        // operator to calc
        string operat;
        do
        {
            Console.Write("Write the operator: ");
            try
            {
                operat = Console.ReadLine()!;
                if(!string.IsNullOrWhiteSpace(operat) && "+-*/".Contains(operat))
                {
                    break;
                }
                Console.WriteLine("Invalid! Write a correct operator.");

            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);    
            }

        } while(true);

        // second number.
        double n2 = 0;
        do
        {
            Console.Write("Write a second number: ");
            try
            {
                n2 = ValidateAndParse(Console.ReadLine()!, "Invalid! Please, write a correct number.");
                break;

            } catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        } while(true);


        // calcs
        try
        {
            result = operat switch
            {
                "+" => n1 + n2,
                "-" => n1 - n2,
                "*" => n1 * n2,
                "/" => (n2 != 0) ? n1 / n2 : throw new DivideByZeroException(), _ => throw new ArgumentException("Invalid operator!")
            };

        
            // verify if the input is integer
            if(double.IsInteger(result))
            {
                Console.WriteLine($"✅ Result: {result.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine($"✅ Result: {result.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
            }

            
            Console.WriteLine("---------------------------");

        }
        catch (DivideByZeroException e)
        {
            // capture all exceptions w/ practice message.
            Console.WriteLine($"❌ Error: {e.Message}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Failed to calc. Please, try again!");
        }

        return result;
    }

    private static double ValidateAndParse(string value, string errorMsg)
    {
        if(string.IsNullOrWhiteSpace(value) || !double.TryParse(value, System.Globalization.CultureInfo.InvariantCulture, out double result))
        {
            throw new ArgumentException(errorMsg);
        }

        return result;
    }
}