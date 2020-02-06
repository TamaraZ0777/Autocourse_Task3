using System;

namespace ArrayTraining_Task3
{
    class Program
    {
        static void Main(string[] args)

        {
            int arrayMinSize = 9;

            Console.WriteLine($"We are going to create an array of numbers. There should be least {arrayMinSize + 1} numbers in the array.");
            
            var minValue = ValidateMinValue(ReadValueFromConsole("Please enter a positive number to start the array with: "));
            var maxValue = ValidateMaxValue(ReadValueFromConsole("Please enter a number that will be the last in the array: "));

            Console.WriteLine("Your array starts with: " + minValue + " and ends with: " + maxValue + ".");

            ArrayOfNumbers MyArray = new ArrayOfNumbers(minValue, maxValue);

            
            int sumOfNumbers = MyArray.CalculateSum();

            Console.WriteLine("The sum of the numbers in the array that can be divided by 3 but cannot be divided by 5 is {0}.", sumOfNumbers);

            
            static int ReadValueFromConsole(string message)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(message);
                    var input = Console.ReadLine();
                    if (int.TryParse(input, out int value))
                    {
                        Console.WriteLine($"You entered" +
                        $" {value}.");
                        return value;
                    }

                    Console.WriteLine("Sorry, the value is not valid. It should be a positive integer.");
                    
                }
                return 0;
            }

            int ValidateMinValue(int inputNumber)
            {
                if (inputNumber <= 0)
                {
                    Console.WriteLine("Incorrect data entered 3 times. The value will be set randomly in the range from 1 to 1000:");

                    Random random = new Random();
                    inputNumber = random.Next(1, 1000);

                    Console.WriteLine($"The array will start from {inputNumber}");
                }
                return inputNumber;
            }

            int ValidateMaxValue(int inputNumber)
            {
                if (inputNumber < (minValue + arrayMinSize))
                {
                    Console.WriteLine($"There should be at least 10 numbers in the array. We will add {arrayMinSize} to the first number of the array:");

                    inputNumber = minValue + arrayMinSize;

                    Console.WriteLine($"the array will end with {inputNumber}.");
                }

                return inputNumber;
            }
        }
    }
}
