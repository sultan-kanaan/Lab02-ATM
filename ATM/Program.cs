using System;

namespace ATM
{
    class Program
    {
        static public decimal Balance = 100;


        static void Main(string[] args)
        {
            UserInterface();
           


        }
        public static void UserInterface() 
        {
            Console.WriteLine(ViewBalance());
            Console.WriteLine(Withdraw());
            Console.WriteLine(Deposit());
        }

        public static decimal ViewBalance()
        {
            
            return Balance;
        }
        public static decimal Withdraw()
        {
            Console.WriteLine("Please enter the amount to be withdrawn");
            String amountwithdraw = Console.ReadLine();
            decimal Amountwithdraw = Convert.ToDecimal(amountwithdraw);
            try
            {
                if (Amountwithdraw < 0)
                {
                    throw new Exception($"opps the {Amountwithdraw} is lees then zero");

                }
                if (Amountwithdraw > Balance)
                {
                    throw new Exception($"opps the {Amountwithdraw} is bigger than {Balance} ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Balance -=  Amountwithdraw;
               

            return Balance;
        }
        public static decimal Deposit()
        {
            Console.WriteLine("Please enter the amount to be deposited");
            String amountDeposit = Console.ReadLine();
            decimal AmountDeposit = Convert.ToDecimal(amountDeposit);
            try
            {

            
            if (AmountDeposit < 0) 
            {
                throw new Exception($"opps the {AmountDeposit} is lees then zero");
                
            }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Balance += AmountDeposit;
            return Balance;
        }
    }
}
