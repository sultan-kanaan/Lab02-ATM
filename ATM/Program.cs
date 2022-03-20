using System;

namespace ATM
{
     public class Program
    {
        static public decimal Balance = 1000 ;

        public static void Main(string[] args)
        {

            try
            {
                UserInterface();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UserInterface()
        {
            bool menu = true;
            while (menu != false)
            {

            
            Console.WriteLine(" ________________________________________________");
            Console.WriteLine("|                                                |");
            Console.WriteLine("| welcome to MYBANK Please choose the operation :|");
            Console.WriteLine("|                                                |");
            Console.WriteLine("| 1. View Balance                                |");
            Console.WriteLine("| 2. Withdraw                                    |");
            Console.WriteLine("| 3. Deposit                                     |");
            Console.WriteLine("| 4. Exit                                        |");
            Console.WriteLine("|                                                |");
            Console.WriteLine(" ________________________________________________");
            int operation = Convert.ToInt32(Console.ReadLine());

           
                switch (operation)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(ViewBalance());
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please enter the amount to be withdrawn");
                        decimal Amountwithdraw = Convert.ToDecimal(Console.ReadLine());
                        Withdraw(Amountwithdraw);
                        Console.WriteLine("your Balance is : " + Balance);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Please enter the amount to be deposited");
                        decimal Amountdeposited = Convert.ToDecimal(Console.ReadLine());
                        Deposit(Amountdeposited);
                        Console.WriteLine("your Balance is : " + Balance);
                        break;
                    case 4:
                        menu = false;
                        Console.WriteLine("thank you for using MYBANK -_ - ");
                        break;
                    default:
                        Console.WriteLine(" Invalid number... Please choose the number of the operation ");
                        break;
                }
            }

        }
        public static decimal ViewBalance()
        {
            
            return Balance;
        }
        public static decimal Withdraw(decimal Amount)
        {
          
                if (Amount < 1)
                {
                    Console.WriteLine($"opps the {Amount} is lees then one");
                    return Balance;

            }
            if (Amount > Balance)
                {
                   Console.WriteLine($"opps the {Amount} is bigger than {Balance} ");
                return Balance;
                }

            else
            {
            Balance -=  Amount;

            return Balance;

            }
        }
        public static decimal Deposit(decimal Amount)
        {
        
            
            if (Amount < 1) 
            {
                Console.WriteLine($"opps the {Amount} is lees then one");
                return Balance;
            }
            else
            {

            Balance += Amount;
            return Balance;

            }
        }
        



    }
}
