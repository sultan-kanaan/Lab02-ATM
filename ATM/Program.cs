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
                    Console.Write("your Balance is : ");
                    Console.WriteLine(Withdraw(Amountwithdraw));
                    Main();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Please enter the amount to be deposited");
                    decimal Amountdeposited = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("your Balance is : ");
                    Console.WriteLine(Deposit(Amountdeposited));
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
            try
            {
                if (Amount < 1)
                {
                    throw new Exception($"opps the {Amount} is lees then one");

                }
                if (Amount > Balance)
                {
                    throw new Exception($"opps the {Amount} is bigger than {Balance} ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Balance -=  Amount;
           // Console.Write("your Balance is : ");


            return Balance;
        }
        public static decimal Deposit(decimal Amount)
        {
            //Console.WriteLine("Please enter the amount to be deposited");
           // decimal Amount = Convert.ToDecimal(Console.ReadLine());
            try
            {

            
            if (Amount < 1) 
            {
                throw new Exception($"opps the {Amount} is lees then one");
                
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Balance += Amount;
            return Balance;

        }
        



    }
}
