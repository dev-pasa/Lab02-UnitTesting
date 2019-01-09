using System;

namespace Lab02_UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
           SuperFront();
        }

        static int SuperFront()
        {
            bool Event = true;
            while(Event)
            {

            double Balance = 3000;
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
                    Console.WriteLine($"Your balance is {Balance}");
                    break;

                    case 2:
                    Console.WriteLine("How much would you like to withdraw");
                    double withDrawAmt; 
                    double.TryParse(Console.ReadLine(), out withDrawAmt);
                    WithDraw(withDrawAmt);
                    Console.WriteLine($"Your new balance is {Balance}");

                    case 3:
                    Console.WriteLine("How much would you like to deposit");
                    double depositAmt;
                    double.TryParse(Console.ReadLine(), out depositAmt);
                    Deposit(depositAmt);        
                    Console.WriteLine($"Your new balance is {Balance}");
                    
                    case 4:
                    Console.WriteLine("Thank you for your business");
                    Event = false;
        
                    default:
                    //Console.WriteLine("Invalid selection. Please select 1, 2, 3 or 4.");
                    break;
                }
            return;
        
            }

         }
        
        public static string WithDraw(double withDrawAmt)
        {
            if(withDrawAmt > 0)
            {
                Console.WriteLine("Insufficient funds");
            }            
                Balance -=withDrawAmt; 
                return "Withdraw success";          
        }

        public static string Deposit(double depositAmt)
        {
            if(depositAmt < 0)
            {
                Console.WriteLine("Can't deposit, try withdraw");
            }           
                Balance +=withDrawAmt; 
                return "Deposit success";            
        }

            
    }
}
