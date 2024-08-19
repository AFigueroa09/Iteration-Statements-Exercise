namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        static void Printnumbers ()
        {
            int num = 1000;
            while (num >= -1000)
            {
                Console.WriteLine(num);
                num--;
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        static void PrintEveryThirdNumber()
        {
            int num = 3;
            while (num <= 999) {
                Console.WriteLine(num);
                num = num + 3;
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        static bool AreNumbersEqual(int num1, int num2) { 
            return num1 == num2;
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        static bool IsEven(int number)
        {
            int modulus =  number % 2;
            return modulus == 0;
        }
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        static bool IsPositive(int number)
        {
            return number >= 0;
        }
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        static bool CanVote(string age)
        {
            bool result = int.TryParse(age, out int parsedAge);
            if (result)
            {
                return parsedAge >= 18;
            } else
            {
                Console.WriteLine("Error! Cannot parse argument. Please try again");
                return false;
            }
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        static bool IsInRange(int number)
        {
            return number <= 10 && number >= -10;
        }
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }
        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Printnumbers();

            bool isEven = IsEven(3);
            Console.WriteLine($"Is 3 even? {isEven}");
            isEven = IsEven(4);
            Console.WriteLine($"Is 4 even? {isEven}");

            PrintEveryThirdNumber();

            bool areEqual = AreNumbersEqual(1, 2);
            Console.WriteLine($"Are 1 and 2 equal? {areEqual}");
            areEqual = AreNumbersEqual(2, 2);
            Console.WriteLine($"Are 2 and 2 equal? {areEqual}");

            bool isPositive = IsPositive(2);
            Console.WriteLine($"Is 2 Positive? {isPositive}");
            isPositive = IsPositive(-4);
            Console.WriteLine($"Is -4 Positive? {isPositive}");

            bool canVote = CanVote("30");
            Console.WriteLine($"Can age 30 vote? {canVote}");
            canVote = CanVote("3");
            Console.WriteLine($"Can age 3 vote? {canVote}");
            canVote = CanVote("dogs");
            Console.WriteLine($"Can dogs vote? {canVote}");

            bool isInRange = IsInRange(2);
            Console.WriteLine($"Is 2 in range? {isInRange}");
            isInRange = IsInRange(-14);
            Console.WriteLine($"Is -14 in range? {isInRange}");
            isInRange = IsInRange(14);
            Console.WriteLine($"Is 14 in range? {isInRange}");

            DisplayMultiplicationTable(1);
            DisplayMultiplicationTable(5);
            DisplayMultiplicationTable(12);
        }
    }
}
