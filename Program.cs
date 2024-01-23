using System;

namespace GuessNumber
{
    class myClass
    {
        static void Main(string[] args)
        {
            bool main = true;

            while (main)
            {
                int user, attempt = 0, option, counter = 0;
                int computer = new Random().Next(1, 15);
            
                System.Console.WriteLine("\nWelcome to Number Guessing Game\n");
                System.Console.WriteLine("[1] Play\n[2] Exit");
                System.Console.Write("Option: ");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    System.Console.WriteLine("Well, .......");
                    System.Console.WriteLine("Computer has chosen a number");
                    while (attempt < 15)
                    {
                        Console.Write("Raqam tanlang: [1-15]: ");
                        user = Convert.ToInt32(Console.ReadLine());
                        if (user == computer)
                        {
                            if (attempt == 3)
                            {
                                System.Console.WriteLine("Correct");
                                counter++;
                                attempt++;
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Correct");
                                attempt++;
                                counter++;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect");

                            attempt++;
                        }
                    }

                    if (counter > 0)
                    {
                        System.Console.WriteLine($"You found the number within {attempt} attempts");
                    }
                    else if(attempt > 1)
                    {
                        System.Console.WriteLine($"You found the number within {attempt} attempts");
                    }else
                    {
                        System.Console.WriteLine($"You found the number within {attempt} attempt");    
                    }
                }
                else if (option == 2)
                {
                    System.Console.WriteLine("Good Bye!");
                    main = false;
                }
                else
                {
                    System.Console.WriteLine("Invalid option...");
                }
            }
        }
    }
}