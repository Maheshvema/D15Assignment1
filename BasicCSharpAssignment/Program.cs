using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        public static string choice;
        
        static void Main(string[] args)
        {   //Task-1
            Console.WriteLine("Hello World!");
            //Task-2
            Console.Write("Enter your name:");
            string name=Console.ReadLine();
            Console.WriteLine("Hello " + name + " !" );
            //task-3
            do
            {
                Console.Write("Enter first number:");
                int Number1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Second number:");
                int Number2 = int.Parse(Console.ReadLine());
                Console.Write("Enter option to arthematic options");
                Console.WriteLine("1.Add 2.Sub 3.Mul 4.DiV 5.Mod");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        int result1 = Number1 + Number2;
                        Console.WriteLine("The result of Addition is : {0}", result1);
                        break;
                    case 2:
                        int result2 = Number1 - Number2;
                        Console.WriteLine("The result of Subtraction is : {0}", result2);
                        break;
                    case 3:
                        int result3 = Number1 * Number2;
                        Console.WriteLine("The result of Multiplication is : {0}", result3);
                        break;
                    case 4:
                        int result4 = Number1 / Number2;
                        Console.WriteLine("The result of Division is : {0}", result4);
                        break;
                    case 5:
                        {
                            int result5 = Number1 % Number2;
                            Console.WriteLine("The result of Mod is :{0}", result5);
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("do you want continue ..if yes press y");
                string choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            //Task-4
            Console.WriteLine("Enter number to find even odd");
            int Num=int.Parse(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("Given number is even:"+ Num);
            } 
            else
            {
                Console.WriteLine("Given number is odd :"+ Num);
            }
            //Task-5
            Console.WriteLine("Printing 1 to 10 numbers");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            //Task-6
            int[] numbersArray = { 1,2,3,4,5 };
            int sum = 0;

            foreach (int num in numbersArray)
            {
                sum += num;
            }

            double average = (double)sum / numbersArray.Length;
            Console.WriteLine($"Sum: {sum}, Average: {average}");
            //Task-7
            Console.WriteLine("Method to calculate the factorial");
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            FactorialClass fact = new FactorialClass();
            double result = fact.factoral(number);
            Console.WriteLine($"Factorial of entered number {number} is: " + result);
            //Task-8
            int age;

            while (true)
            {
                Console.Write("Enter your age: ");

                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }
            Console.ReadKey();
        }
    }
}
