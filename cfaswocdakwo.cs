using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_1;
            int number_2;
            char sym;
            Console.WriteLine("Enter first number:");
            Int32.TryParse(Console.ReadLine(), out number_1);
            Console.WriteLine("Enter second number:");
            Int32.TryParse(Console.ReadLine(), out number_2);
            Console.WriteLine("Enter some sym:");
            char.TryParse(Console.ReadLine(), out sym);
            if (sym == '/')
            {
                if (number_2 == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    Console.WriteLine(number_1 / number_2);
                }
            }
            else if (sym == '+')
            {
                Console.WriteLine(number_1 + number_2);
            }
            else if (sym == '-')
            {
                Console.WriteLine(number_1 - number_2);
            }
            else if (sym == '*')
            {
                Console.WriteLine(number_1 * number_2);
            }
            else {
                Console.WriteLine("Error");
            }
            
            double bill;
            double procent;
            Console.WriteLine("Enter bill:");
            double.TryParse(Console.ReadLine(), out bill);
            Console.WriteLine("Enter procent:");
            double.TryParse(Console.ReadLine(), out procent);
            if (procent == 0) {
                Console.WriteLine(bill);
            }
            else
            {
                Console.WriteLine( bill + bill * (procent/100));
            }

            int size = 10;
            int[] nums = new int[size];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = random.Next(-50, 50);
            }
            Console.WriteLine("Massive: ");
            Console.WriteLine(nums);


            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            for (int i = 0; i < nums[i]; i++) {
                if (nums[i] > max) {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            Console.WriteLine("Massive: " + string.Join(", " , nums));
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Summa: " + sum);


            
            double balance = 0;
            int choice;
            double amount;
            
            do
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Select an action: ");
                choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        balance += amount;
                        Console.WriteLine($"Account credited. New balance: {balance}");
                        Console.ReadKey();
                        break;
            
                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        amount = Convert.ToDouble(Console.ReadLine());
            
                        if (amount > balance)
                        {
                            Console.WriteLine("Insufficient funds!");
                            Console.ReadKey();
                        }
                        else
                        {
                            balance -= amount;
                            Console.WriteLine($"Funds withdrawn. New balance: {balance}");
                            Console.ReadKey();
                        }
                        break;
            
                    case 3:
                        Console.WriteLine($"Current balance: {balance}");
                        Console.ReadKey();
                        break;
            
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
            
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (choice != 4);
        }
    }
}
