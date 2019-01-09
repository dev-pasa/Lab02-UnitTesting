using System;

namespace Lab02_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
           SuperFront();
        }


        public static void SuperFront()
        {

            double Balance = 3000;

            bool Event = true;
            while(Event)
                
            {
            Console.WriteLine("Hello! Welcome to your local Bank");
            Console.WriteLine("How can I help you today?");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Add Money");
            Console.WriteLine("4. Cancel Transaction");
            int userInput = Int32.Parse(Console.ReadLine());

                try
                    {

                    }
                catch (Exception)
                    {
                        Console.WriteLine("Enter a 1, 2, 3 or 4");
                    }
                 
                switch(userInput)
                {
                    case 1:
                    Console.WriteLine($"Your balance is ${Balance}");
                    break;

                    case 2:
                    Console.WriteLine("How much would you like to withdraw");
                    double withDrawAmt; 
                    double.TryParse(Console.ReadLine(), out withDrawAmt);
                    
                    if(withDrawAmt > Balance)
                        {
                            Console.WriteLine("Withdraw amount greater than balance");
                        }
                        else
                        {
                            Balance = WithDraw(withDrawAmt, Balance);
                        }
                    Console.WriteLine($"Your balance is ${Balance}");
                    break;

                    case 3:
                    Console.WriteLine("How much would you like to deposit");
                    double depositAmt;
                    double.TryParse(Console.ReadLine(), out depositAmt);
                    Balance = Deposit(depositAmt, Balance);        
                    Console.WriteLine($"Your balance is ${Balance}");
                    break;

                    case 4:
                    Console.WriteLine("Thank you for your business");
                    Event = false;
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3 or 4.");
                    break;
                }

                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("1. Go to Main Menu");
                Console.WriteLine("4. Exit");
                int newSelect = Int32.Parse(Console.ReadLine());
                if (newSelect == 1)
                {
                    newSelect = userInput;
                }
                else if (newSelect == 4)
                {
                    Environment.Exit(0);
                }

            }
         }
        
        public static double WithDraw(double withDrawAmt, double Balance)
        {
            if(withDrawAmt < 0)
            {
                return Balance;
            }
            else if(withDrawAmt > Balance)
            {
                return Balance;
            }
                Balance -=withDrawAmt; 
                return Balance;          
        }

        public static double Deposit(double depositAmt, double Balance)
        {
            if(depositAmt < 0)
            {
                return 0;
            }           
                Balance += depositAmt;
            return Balance;            
        }

            
    }
}
