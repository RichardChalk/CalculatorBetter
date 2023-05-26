namespace CalculatorBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instruktioner.
            Console.WriteLine("Enter ekvation inklusive mellanslag (tex. 5 + 5).");
            Console.WriteLine("Eller skriv 'Avsluta'");

            while (true)
            {
                // Get input from the user, split it up into the three pieces
                // (separated by spaces), to be ready to do the calculation.
                Console.Write(">>>");
                string text = Console.ReadLine();

                // Time to end
                if (text == "Avsluta")
                {
                    break;
                }

                string[] parts = text.Split(' ');
                int number1 = Convert.ToInt32(parts[0]);
                string operation = parts[1];
                int number2 = Convert.ToInt32(parts[2]);

                // The result will be stored in this variable.
                int result;

                // Do a different operation depending on the text the user
                // supplied.
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    case "%":
                        result = number1 % number2;
                        break;
                    case "^":
                        result = (int)Math.Pow(number1, number2);
                        break;
                    default:
                        Console.WriteLine("Unrecognized operator: " +
                                    operation);
                        result = 0;
                        break;
                }

                // Print out the results.
                Console.WriteLine(number1 + " " + operation + " " + number2
                            + " = " + result);
            }
        }
    }
}