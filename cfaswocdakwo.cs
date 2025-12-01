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
        }
    }
}
