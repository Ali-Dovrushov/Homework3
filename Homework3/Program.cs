using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool selection = true;
            bool selection1 = false;
            Console.WriteLine("Question №1");

            int even_sum = 0;
            int even_total = 0;

            for (int i = 2; i < 99; i++)
            {
                if (i % 2 == 0)
                {
                    even_sum += i;
                    even_total++;
                }
            }

            Console.WriteLine($"Summ of even numbers: {even_sum}");
            Console.WriteLine($"Number of even numbers: {even_total}");

            ////

            Console.WriteLine("\nQuestion №2");

            do
            {
                Console.Write("Enter number: ");

                bool checker = true;
                int number = Convert.ToInt32(Console.ReadLine());
                int for_calc_number = (number - number % 2) / 2;

                for (int i = 2; i <= for_calc_number; i++)
                {
                    if (number % i == 0)
                    {
                        checker = false;
                        break;
                    }

                }

                string result = checker == true ? "Simple number" : "Complex number";
                Console.WriteLine($"Result: {result}");

                Console.Write("Would you try again ? (Y/y) or (N/n): ");
                do
                {
                    char otvet = Convert.ToChar(Console.ReadLine());
                    switch (otvet)
                    {
                        case 'Y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selection1 = false;
                                selection = true;
                                continue;
                            }
                    }
                }
                while (selection1 == false);
            }
            while (selection == true);

            ////

            Console.WriteLine("\nQuestion №3");
            do
            {
                Console.WriteLine("Calculating factorial");
                Console.Write("Enter number(please enter number < 65, i have ULong but it's so big number): ");

                ulong factorial_number = Convert.ToUInt64(Console.ReadLine());
                ulong calc_fact = 1UL;

                for (ulong i = 1; i <= factorial_number; i++)
                {
                    calc_fact *= i;
                }

                Console.WriteLine($"Result: {calc_fact}");
                Console.Write("Would you try again ? (Y/y) or (N/n): ");
                do
                {
                    char checker_switch_for_3 = Convert.ToChar(Console.ReadLine());
                    switch (checker_switch_for_3)
                    {
                        case 'Y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selection = true;
                                selection1 = false;
                                continue;
                            }
                    }
                }
                while (selection1 == false);
            }
            while (selection == true);

            Console.WriteLine("\nQuestion №4");

            do
            {
                Console.WriteLine("Sum of given numbers");
                Console.Write("Enter number: ");
                int your_number = Convert.ToInt32(Console.ReadLine());
                int your_number_summ = 0;

                while (your_number > 0)
                {
                    your_number_summ += your_number % 10;
                    your_number /= 10;
                }
                Console.WriteLine($"Result: {your_number_summ}");
                Console.Write("Would you try again ? (Y/y) or (N/n): ");
                do
                {
                    char checker_switch_for_3 = Convert.ToChar(Console.ReadLine());

                    switch (checker_switch_for_3)
                    {
                        case 'Y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selection = true;
                                selection1 = false;
                                continue;
                            }
                    }
                }
                while (selection1 == false);
            }
            while (selection == true);

            Console.WriteLine("\nQuestion №5");

            do
            {
                Console.Write("Enter number: ");
                int mirror_number = Convert.ToInt32(Console.ReadLine());
                while (mirror_number > 0)
                {
                    Console.Write(mirror_number % 10);
                    mirror_number /= 10;
                }
                Console.Write("\nWould you try again ? (Y/y) or (N/n): ");
                do
                {
                    char checker_switch_for_3 = Convert.ToChar(Console.ReadLine());
                    switch (checker_switch_for_3)
                    {
                        case 'Y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'y':
                            {
                                selection = true;
                                selection1 = true;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        case 'n':
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selection1 = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selection = true;
                                selection1 = false;
                                continue;
                            }
                    }

                }
                while (selection1 == false);
            }
            while (selection == true);

            Console.ReadKey();
        }
    }
}