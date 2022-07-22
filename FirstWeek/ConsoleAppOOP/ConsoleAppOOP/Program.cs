

namespace MySuperBank
{
    class Program
    {
        static void Main(String[] args)
        {
            var account = new BankAccount("ramazan karkin", 5500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}$.");

            account.MakeWithdrawal(10, DateTime.Now, "buy new chocolate");
            Console.WriteLine(account.Balance);


            account.MakeWithdrawal(35, DateTime.Now, "Starbucks Coffee");
            Console.WriteLine(account.Balance);


            Console.WriteLine(account.GetAccountHistory());





            //var account2 = new BankAccount("Enes şenol", 13500);
            //Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance}$.");

            // Testing for negative balance.
            //try
            //{
            //    account.MakeWithdrawal(11200, DateTime.Now, "Attempt to overdraw");
            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw.");
            //    Console.WriteLine(e.ToString());
            //}




            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -23);

            //}
            //catch (ArgumentOutOfRangeException e)
            //{
                
            //    Console.WriteLine(e.ToString());

            //}
            
        }
    }
}