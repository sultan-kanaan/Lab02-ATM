using System;

namespace ATM
{
     public class Program
    {
        static public decimal Balance = 1000 ;
        //static public decimal Amount  ;

        public static void Main()
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
            int operation = Convert.ToInt32( Console.ReadLine());
            
            UserInterface(operation);
           


        }
        public static void UserInterface(int operation) 
        {
            switch (operation)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(ViewBalance());
                    Main();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Please enter the amount to be withdrawn");
                    decimal Amountwithdraw = Convert.ToDecimal(Console.ReadLine());
                    Withdraw(Amountwithdraw);
                    Console.WriteLine("your Balance is : " + Balance);

                    Main();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Please enter the amount to be deposited");
                    decimal Amountdeposited = Convert.ToDecimal(Console.ReadLine());
                    Deposit(Amountdeposited);
                    Console.WriteLine("your Balance is : " + Balance);

                    Main();
                    break;
                case 4:
                    Console.WriteLine("thank you for using MYBANK -_ - ");
                    break;
                default:
                    throw new Exception(" Invalid number... Please choose the number of the operation ");
            }
            
        }

        public static decimal ViewBalance()
        {
            
            return Balance;
        }
        public static decimal Withdraw(decimal Amount)
        {
            //Console.WriteLine("Please enter the amount to be withdrawn");
           //decimal Amountwithdraw = Convert.ToDecimal(Console.ReadLine());
                if (Amount < 1)
                {
                    Console.WriteLine($"opps the {Amount} is lees then one");
                    Main();

            }
            if (Amount > Balance)
                {
                   Console.WriteLine($"opps the {Amount} is bigger than {Balance} ");
                   Main();

            }


            Balance -=  Amount;
           // Console.Write("your Balance is : ");


            return Balance;
        }
        public static decimal Deposit(decimal Amount)
        {
            //Console.WriteLine("Please enter the amount to be deposited");
           // decimal Amount = Convert.ToDecimal(Console.ReadLine());
            
            if (Amount < 1) 
            {
                Console.WriteLine($"opps the {Amount} is lees then one");
                Main();
            }
            
            Balance += Amount;
            return Balance;

        }
        



    }
}
