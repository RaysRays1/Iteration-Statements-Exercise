using System.Data.SqlTypes;

namespace IterationStatements3

{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        public static void PrintNumber()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThridNumber()
        {

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static bool AreNumbersEqual()
        {
            int num1 = 10;
            int num2 = 10;    

            if (num1 == num2)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number)
        {
            if (number - 2 <= 3)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        public static bool CanVote()
        {
            int Age = 18;
            Console.WriteLine("What your age");
            string userInput = Console.ReadLine();
            int parsedUserInput = int.Parse(userInput);

            if (parsedUserInput < Age)
            {
                Console.WriteLine("You cannot vote");
            }
            else if (parsedUserInput >= Age)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("Thanks for visiting");
            }

            return false;


        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        public static bool IsInRange(int number)
        {
            if (number <= 10 && number >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }


        }







        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        public static void DisplayMultiplicationTable()
        {
            MultiplicationT:
            {
                Console.WriteLine(Multiply(1, 1)); // output: 1
                Console.WriteLine(Multiply2(1, 2)); // output: 2
                Console.WriteLine(Multiply3(1, 3)); // output: 3
                Console.WriteLine(Multiply4(1, 4)); // output: 4
                Console.WriteLine(Multiply5(1, 5)); // output: 5
                Console.WriteLine(Multiply6(1, 6)); // output: 6
                Console.WriteLine(Multiply7(1, 7)); // output: 7
                Console.WriteLine(Multiply8(1, 8)); // output: 8
                Console.WriteLine(Multiply9(1, 9)); // output: 9
                Console.WriteLine(Multiply10(1, 10)); // output: 10
                Console.WriteLine(Multiply11(1, 11)); // output: 11
                Console.WriteLine(Multiply12(1, 12)); // outtput: 12
            }

            static int Multiply(int a, int b)
            {
                return a * b;
            }

            static int Multiply2(int a, int b)
            {
                return a * b;
            }

            static int Multiply3(int a, int b)
            {
                return a * b;
            }

            static int Multiply4(int a, int b)
            {
                return a * b;
            }

            static int Multiply5(int a, int b)
            {
                return a * b;
            }

            static int Multiply6(int a, int b)
            {
                return a * b;
            }

            static int Multiply7(int a, int b)
            {
                return a * b;
            }

            static int Multiply8(int a, int b)
            {
                return a * b;
            }

            static int Multiply9(int a, int b)
            {
                return a * b;
            }

            static int Multiply10(int a, int b)
            {
                return a * b;
            }

            static int Multiply11(int a, int b)
            {
                return a * b;
            }

            static int Multiply12(int a, int b)
            {
                return a * b;
            }

        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {

            //PrintNumber();
            //PrintEveryThridNumber();
            //AreNumbersEqual();
           // bool answer1 = IsEven(3);
            //Console.WriteLine(answer1);
            //bool answer2 = IsPositive(2);
            //Console.WriteLine(answer2);
            //CanVote();
            
            Console.WriteLine("give me a number to check a range");
            var canParse = int.TryParse(Console.ReadLine(), out int number);

            while (!canParse)
            {
                Console.WriteLine("Please enter a number");
                canParse = int.TryParse(Console.ReadLine(), out number);
                
            }
            Console.WriteLine(IsInRange(number));
            
            
            // DisplayMultiplicationTable();

        }
    }
}